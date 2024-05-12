namespace dotnet_error_lookup.Data.Errors;

public class CS1008 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1008";
    string IErrorOrWarning.Message => @"Type byte, sbyte, short, ushort, int, uint, long, or ulong expected";
    string IErrorOrWarning.Explanation => @"[original] Type byte, sbyte, short, ushort, int, uint, long, or ulong expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1008";
}
