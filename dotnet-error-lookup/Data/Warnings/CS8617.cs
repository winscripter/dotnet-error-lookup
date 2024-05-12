namespace dotnet_error_lookup.Data.Errors;

public class CS8617 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8617";
    string IErrorOrWarning.Message => @"Nullability of reference types in type of parameter '{0}' doesn't match implemented member '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in type of parameter '{0}' doesn't match implemented member '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
