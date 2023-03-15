# Debugging

To debug the code generated by Mapperly just set a breakpoint in the generated code and you are ready to go.
Check [here](../configuration/generated-source) on how to inspect the generated code.

To debug the Mapperly in unit tests set a breakpoint
in the code of Mappery which you want to debug and run the tests in debug mode.

Since Mapperly runs integrated into the build pipeline,
debugging integration tests and other applications needs some more effort.
Mapperly uses a compile constant `DEBUG_SOURCE_GENERATOR` to determine whether to attach a debugger.
If it is set, it tries to attach a debugger
(it uses `Debugger.Launch()` on windows, on other operating systems it tries to launch JetBrains Rider)
and waits for the connection of the debugger (for up to 30 seconds).
If the automatic debugger attachment fails you can use these 30 seconds to attach the debugger manually
(for vs 2022 see [attach to running processes](https://docs.microsoft.com/en-us/visualstudio/debugger/attach-to-running-processes-with-the-visual-studio-debugger?view=vs-2022)).
You can use the `DefineConstants` dotnet build or csproj parameter to define the `DEBUG_SOURCE_GENERATOR` constant.

For the debugger attachment with JetBrains Rider to work correctly,
`Generate Shell Scripts` needs to be enabled in the JetBrains ToolBox
and the generated shell scripts need to be on the path (Mapperly calls `rider attach-to-process {pid} {Mapperly-Sln-File}`).