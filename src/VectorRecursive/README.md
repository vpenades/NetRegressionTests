### System.Numerics.Vectors Access Violation Exception.

Apparently, this issue happens when the JIT unrolls a recusive function into a loop.

It crashes only in **x64** **Release** mode.

Reported [here](https://github.com/dotnet/coreclr/issues/19022)

Theoretically, it's been fixed [here](https://github.com/dotnet/coreclr/pull/19065#issuecomment-413612261),
but not sure if the fix has been released, since this POC is still crashing in my machine.