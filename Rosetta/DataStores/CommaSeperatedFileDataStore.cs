#region References

using System;
using System.Collections.Generic;
using System.Text;
using Rosetta.Configuration;

#endregion

namespace Rosetta.DataStores
{
	public class CommaSeperatedFileDataStore : FileDataStore
	{
		#region Constants

		public const string Filter = "Comma Seperated File (csv)|*.csv";
		private const char CommaCharacter = ',';
		private const char QuoteCharacter = '"';

		#endregion

		#region Constructors

		public CommaSeperatedFileDataStore(DataStoreConfiguration configuration)
			: base(configuration)
		{
		}

		#endregion

		#region Methods

		public override string ConvertRow(DataRow row)
		{
			if (row.Count != Configuration.Columns.Count)
			{
				throw new ArgumentException("The row does not match the column count.");
			}

			var builder = new StringBuilder(1024);

			foreach (var item in row)
			{
				if (builder.Length > 0)
				{
					builder.Append(",");
				}

				if (!item.Value.Contains(","))
				{
					builder.Append(item.Value);
					continue;
				}

				builder.AppendFormat("{0}{1}{0}", "\"", item.Value);
			}

			return builder.ToString();
		}

		public override DataRow ParseRow(string data)
		{
			var values = ParseLine(data);
			return NewRow(values);
		}

		private string[] ParseLine(string data)
		{
			var context = new ParserContext();
			ParserState currentState = ParserState.LineStartState;

			foreach (var ch in data)
			{
				switch (ch)
				{
					case CommaCharacter:
						currentState = currentState.Comma(context);
						break;

					case QuoteCharacter:
						currentState = currentState.Quote(context);
						break;

					default:
						currentState = currentState.AnyChar(ch, context);
						break;
				}
			}

			currentState.EndOfLine(context);
			return context.Values.ToArray();
		}

		#endregion

		#region Classes

		private class LineStartState : ParserState
		{
			#region Methods

			public override ParserState AnyChar(char ch, ParserContext context)
			{
				context.AddChar(ch);
				return ValueState;
			}

			public override ParserState Comma(ParserContext context)
			{
				context.AddValue();
				return ValueStartState;
			}

			public override ParserState EndOfLine(ParserContext context)
			{
				return LineStartState;
			}

			public override ParserState Quote(ParserContext context)
			{
				return QuotedValueState;
			}

			#endregion
		}

		private class ParserContext
		{
			#region Fields

			private readonly StringBuilder _currentValue = new StringBuilder();

			#endregion

			#region Constructors

			public ParserContext()
			{
				Values = new List<string>();
			}

			#endregion

			#region Properties

			public List<string> Values { get; }

			#endregion

			#region Methods

			public void AddChar(char ch)
			{
				_currentValue.Append(ch);
			}

			public void AddValue()
			{
				Values.Add(_currentValue.ToString());
				_currentValue.Remove(0, _currentValue.Length);
			}

			#endregion
		}

		private abstract class ParserState
		{
			#region Fields

			public static readonly LineStartState LineStartState = new LineStartState();
			public static readonly QuotedValueState QuotedValueState = new QuotedValueState();
			public static readonly QuoteState QuoteState = new QuoteState();
			public static readonly ValueStartState ValueStartState = new ValueStartState();
			public static readonly ValueState ValueState = new ValueState();

			#endregion

			#region Methods

			public abstract ParserState AnyChar(char ch, ParserContext context);
			public abstract ParserState Comma(ParserContext context);
			public abstract ParserState EndOfLine(ParserContext context);
			public abstract ParserState Quote(ParserContext context);

			#endregion
		}

		private class QuotedValueState : ParserState
		{
			#region Methods

			public override ParserState AnyChar(char ch, ParserContext context)
			{
				context.AddChar(ch);
				return QuotedValueState;
			}

			public override ParserState Comma(ParserContext context)
			{
				context.AddChar(CommaCharacter);
				return QuotedValueState;
			}

			public override ParserState EndOfLine(ParserContext context)
			{
				return QuotedValueState;
			}

			public override ParserState Quote(ParserContext context)
			{
				return QuoteState;
			}

			#endregion
		}

		private class QuoteState : ParserState
		{
			#region Methods

			public override ParserState AnyChar(char ch, ParserContext context)
			{
				//undefined, ignore "
				context.AddChar(ch);
				return QuotedValueState;
			}

			public override ParserState Comma(ParserContext context)
			{
				context.AddValue();
				return ValueStartState;
			}

			public override ParserState EndOfLine(ParserContext context)
			{
				context.AddValue();
				return LineStartState;
			}

			public override ParserState Quote(ParserContext context)
			{
				context.AddChar(QuoteCharacter);
				return QuotedValueState;
			}

			#endregion
		}

		private class ValueStartState : LineStartState
		{
			#region Methods

			public override ParserState EndOfLine(ParserContext context)
			{
				context.AddValue();
				return LineStartState;
			}

			#endregion
		}

		private class ValueState : ParserState
		{
			#region Methods

			public override ParserState AnyChar(char ch, ParserContext context)
			{
				context.AddChar(ch);
				return ValueState;
			}

			public override ParserState Comma(ParserContext context)
			{
				context.AddValue();
				return ValueStartState;
			}

			public override ParserState EndOfLine(ParserContext context)
			{
				context.AddValue();
				return LineStartState;
			}

			public override ParserState Quote(ParserContext context)
			{
				context.AddChar(QuoteCharacter);
				return ValueState;
			}

			#endregion
		}

		#endregion
	}
}