namespace dotnet_error_lookup.Data.Errors;

public class CS1003 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1003";
    string IErrorOrWarning.Message => @"Syntax error, '{0}' expected";
    string IErrorOrWarning.Explanation => @"[original] Syntax error, '{0}' expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1003";
}
