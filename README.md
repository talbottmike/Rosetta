# Rosetta

Data conversion tool to convert and transform any data type to any other type. Many types of transforming supported. Here are some examples.

This data "a", "b", "c" could be transformed to "abc", "a, b, and c", "a b c", "616263" (bytes), and many more.
This data 1, 2, 3 could be transformed to 123, 6, "1,2,3", "123", and many more.

# Workflow

- Read Source Item
-- ForEach Mapping
--- Convert Each Column to Destination Type
--- Run Pre-Processor(s)
--- Combine columns into single result
--- Run Post-Processor
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


# vNext?
All of these items are just ideas that may or may not come in the future. These are ideas that I've either ran into or think someone could need.

- Filter incoming data from source. The data may already be converted or possibly just data not wanting to be converted.
- Multiple sources with some kind of linking key. 
-- Maybe an item is stretched across multiple database tables but you want a single CSV.
-- Possible you want to output all People and their addresses (1 to Many). You don't mind duplicating the person per each address that they are related to.
- Multiple destinations. What if you need to split one row into multiple tables. Let's say you have three rows of people that have all the same "Person" data but each row also has a unique address. How would you be able to group on the person data then have a sub collection of addresses?
- Support for other data types type when converting.