namespace dotnet_error_lookup.Data.Errors;

public class CS8825 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8825";
    string IErrorOrWarning.Message => @"Return value must be non-null because parameter '{0}' is non-null.";
    string IErrorOrWarning.Explanation => @"[original] Return value must be non-null because parameter '{0}' is non-null.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
