#region References

#endregion

#region References

using Rosetta.Configuration;

#endregion

namespace Rosetta
{
	public interface ITypeConverter<TType>
	{
		#region Methods

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		T ConvertTo<T>(TType input, string format = null);

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <returns> </returns>
		TType Parse(string input);

		/// <summary>
		/// Process the type with the provided settings.
		/// </summary>
		/// <param name="input"> The input to process. </param>
		/// <param name="settings"> The settings to configure the process. </param>
		/// <returns> The result of the type processing. </returns>
		TType Process(TType input, ProcessSettings settings);

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		bool TryParse(string input, out TType value);

		#endregion
	}
}