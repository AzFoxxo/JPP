/*
*   Java++ (JPP) - Java superset transpiler written in C#
*   Copyright (C) 2026 Az Foxxo
*   See LICENSE for details.
*   ----------
*   Exit codes for Java++ transpiler.
*/
namespace JPP;

public enum ExitCodes
{
    Success = 0,
    StandardError = 1,
    InvalidArguments = 2,
    FileNotFound = 3,
    ParseError = 4,
}
