namespace dotnet_error_lookup.Data.Errors;

public class CS1583 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1583";
    string IErrorOrWarning.Message => @"Error reading Win32 resources -- {0}";
    string IErrorOrWarning.Explanation => @"[original] Error reading Win32 resources -- {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1583";
}
