﻿#region References

using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace TransformR.Data
{
    public class CsvParser
    {
        #region Constants

        private const char CommaCharacter = ',';
        private const char QuoteCharacter = '"';

        #endregion

        #region Properties

        public int MaxColumnsToRead { get; set; }
        public bool TrimTrailingEmptyLines { get; set; }

        #endregion

        #region Methods

        public string[][] Parse(TextReader reader)
        {
            var context = new ParserContext();
            if (MaxColumnsToRead != 0)
            {
                context.MaxColumnsToRead = MaxColumnsToRead;
            }

            ParserState currentState = ParserState.LineStartState;
            string next;
            while ((next = reader.ReadLine()) != null)
            {
                foreach (var ch in next)
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
                currentState = currentState.EndOfLine(context);
            }
            var allLines = context.GetAllLines();
            if (TrimTrailingEmptyLines && allLines.Count > 0)
            {
                var isEmpty = true;
                for (var i = allLines.Count - 1; i >= 0; i--)
                {
                    isEmpty = true;
                    for (var j = 0; j < allLines[i].Length; j++)
                    {
                        if (!string.IsNullOrEmpty(allLines[i][j]))
                        {
                            isEmpty = false;
                            break;
                        }
                    }
                    if (!isEmpty)
                    {
                        if (i < allLines.Count - 1)
                        {
                            allLines.RemoveRange(i + 1, allLines.Count - i - 1);
                        }
                        break;
                    }
                }
                if (isEmpty)
                {
                    allLines.RemoveRange(0, allLines.Count);
                }
            }
            return allLines.ToArray();
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
                context.AddLine();
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

            private readonly List<string> _currentLine = new List<string>();
            private readonly StringBuilder _currentValue = new StringBuilder();
            private readonly List<string[]> _lines = new List<string[]>();

            #endregion

            #region Constructors

            public ParserContext()
            {
                MaxColumnsToRead = 1000;
            }

            #endregion

            #region Properties

            public int MaxColumnsToRead { get; set; }

            #endregion

            #region Methods

            public void AddChar(char ch)
            {
                _currentValue.Append(ch);
            }

            public void AddLine()
            {
                _lines.Add(_currentLine.ToArray());
                _currentLine.Clear();
            }

            public void AddValue()
            {
                if (_currentLine.Count < MaxColumnsToRead)
                {
                    _currentLine.Add(_currentValue.ToString());
                }
                _currentValue.Remove(0, _currentValue.Length);
            }

            public List<string[]> GetAllLines()
            {
                if (_currentValue.Length > 0)
                {
                    AddValue();
                }
                if (_currentLine.Count > 0)
                {
                    AddLine();
                }
                return _lines;
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
                context.AddChar('\r');
                context.AddChar('\n');
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
                context.AddLine();
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
                context.AddLine();
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
                context.AddLine();
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