namespace dotnet_error_lookup.Data.Errors;

public class CS1565 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1565";
    string IErrorOrWarning.Message => @"Conflicting options specified: Win32 resource file; Win32 icon";
    string IErrorOrWarning.Explanation => @"[original] Conflicting options specified: Win32 resource file; Win32 icon";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1565";
}
