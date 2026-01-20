/*
*   Java++ (JPP) - Java superset transpiler written in C#
*   Copyright (C) 2026 Az Foxxo
*   See LICENSE for details.
*   ----------
*   Entry point and argument parsing for Java++ transpiler.
*
*   Arguments:
*       -i, --input <file>       Input Java++ file path (required or use of project flag is)
*       -o, --output <file>      Output Java file path (optional, defaults to displaying the output to the console)
*       -p, --project <file>     Input Java++ project file path (directory to recursively transpile all .jpp files) (required or use of input flag is)
*       -h, --help               Display help information
*       -v, --version            Display version information
*/

namespace JPP;

public class Program
{
    public const string Version = "0.0.0 dev";
    public static int Main(string[] args)
    {
        // Print the version for debugging purposes
        Console.WriteLine($"Java++ {Version} version.");

        return (int)ExitCodes.Success;
    }
}
