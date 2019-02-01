### System.Numerics.Vectors Assignment variant 2.

Reported [here](https://github.com/dotnet/coreclr/issues/22293)

This is a variant of VectorsAssignmentVariant1.

It doesn't need latest c# language version, and it doesn't use the "in" referencing.

It still crashes, though, but instead of producing an **AccessViolationException**, it produces a **NullReferenceException**

