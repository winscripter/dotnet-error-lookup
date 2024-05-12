namespace dotnet_error_lookup.Data.Errors;

public class CS8824 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8824";
    string IErrorOrWarning.Message => @"Parameter '{0}' must have a non-null value when exiting because parameter '{1}' is non-null.";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' must have a non-null value when exiting because parameter '{1}' is non-null.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
