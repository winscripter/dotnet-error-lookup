namespace dotnet_error_lookup.Data.Errors;

public class CS2006 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2006";
    string IErrorOrWarning.Message => @"Command-line syntax error: Missing '{0}' for '{1}' option";
    string IErrorOrWarning.Explanation => @"[original] Command-line syntax error: Missing '{0}' for '{1}' option";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2006";
}
