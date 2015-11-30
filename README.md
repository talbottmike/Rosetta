# Rosetta (alpha - more like a prototype of an idea)

Data conversion tool to convert and transform any data type to any other type. Many types of transforming supported. Here are some examples.

This data "a", "b", "c" could be transformed to "abc", "a, b, and c", "a b c", "616263" (bytes), and many more.
This data 1, 2, 3 could be transformed to 123, 6, "1,2,3", "123", and many more.

##### What about more complex examples?

I have a person CSV data file that I need to import into my SQL data store. The file contains their height in two columns of "Height Feet" and "Height Inches". An example would be [John Doe, 5, 11] where John Doe is 5 feet and 11 inches tall. However we want to store the person height as just inches. This means we'll want to multiple the feet data with 12 before we sum but the two columns. You can add a mapping of the two fields with a single pre-processor of [Multiple] with a value of "12" and a filter of "Height Feet" so the filter only runs on the single column. Once all pre-processor have ran you then sum of the values and store them as "Height"

CSV -> "First Name", "Last Name", "Height Feet", "Height Inches"

Mappings

- ["First Name", "Last Name"] -> "Name"
	- Combine = Join
	- Delimiter = ' '
- ["Height Feet", "Height Inches"] -> "Height"
	- Combine = Sum
	- Pre-Processor
		- Multiply with 12 on "Height Feet"

Example

[John, Doe, 5, 11] would convert into [John Doe, 66]

# Workflow

The source and destination item is just an array of strings. The collection is order based on the columns of the data store. If the data store has 6 columns then each item will contain 6 strings of data in a collection. When we write the data row we'll give the destination a data row containing an entry for each column in the destination data store.

- Read Source Item
- ForEach Mapping
  - Convert Each Column to Destination Type
  - Run Pre-Processor(s)
  - Combine columns into single result
  - Run Post-Processor
- Write Destination Item

# Supported Types

### Bool

- System.Boolean (bool)

### Decimal

- System.Decimal (decimal)
- System.Double (double)
- System.Single (float)

### Numbers

- System.Byte (byte)
- System.SByte (sbyte)
- System.Int16 (short)
- System.UInt16 (ushort)
- System.Int32 (int)
- System.UInt32 (uint)
- System.Int64 (long)
- System.UInt64 (ulong)

### String 

- System.Char
- System.String

### Date & Time

- System.DateTime
- System.TimeSpan


# In progress...

I'm still trying to document all the possible formatting string to be use when parsing and converting. Many formatting is supported but document it will take some time. 

Writing more test and coming up with all possible scenarios to test. This obviously is the biggest issue with any conversion tool. How do you handle "X" scenario? I don't know because I had never considered that! If you do have a scenario that doesn't work then just let us know. We'll add support then Rosetta will support it!

# vNext?
All of these items are just ideas that may or may not come in the future. These are ideas that I've either ran into or think someone could need.

- Filter incoming data from source. The data may already be converted or possibly just data not wanting to be converted.
- Multiple sources with some kind of linking key. 
-- Maybe an item is stretched across multiple database tables but you want a single CSV.
-- Possible you want to output all People and their addresses (1 to Many). You don't mind duplicating the person per each address that they are related to.
- Multiple destinations. What if you need to split one row into multiple tables. Let's say you have three rows of people that have all the same "Person" data but each row also has a unique address. How would you be able to group on the person data then have a sub collection of addresses?
- Support for other data types type when converting.


# Coversions

Be sure to check out the format string section for each type.

### Boolean

- **Boolean**
 	- [true] = true
	- [false] = false
- **Decimals** (Decimal,Double,Single)
	- [Greater than 0] = true
	- [Less than or equal to 0] = false
- **Numbers** (Byte,SByte,Int16,UInt16,Int32,UInt32,Int64,UInt64)
	- [Greater than 0] = true
	- [Less than or equal to 0] = false
- **Char**
	- [T, t, 1, "Format String Characters"] = true
	- [Any other value] = false
- **String**
	- [True, T, true, t, 1, "Format String"] = true
	- [Any other value] = false
- **DateTime** (DateTime, TimeSpan)
	- [Equals Format String] = true
	- [Any other value] = false
