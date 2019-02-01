# Net Regression Tests

**System.Numerics.Vectors** is an extremely powerful addition to .Net that greatly
enhances the capabilities of the framework. It is being widely used by Graphics engines,
image processing, physics, etc

But, given it's extreme optimizations, sometimes it hits compiler issues, usually in the form of **AccessViolationException**

This repository is a collection of Proof of concept projects that reproduce these issues
in order to track which conditions reproduce them, and check when they have been fixed.

