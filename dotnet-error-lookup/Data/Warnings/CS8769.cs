namespace dotnet_error_lookup.Data.Errors;

public class CS8769 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8769";
    string IErrorOrWarning.Message => @"Nullability of reference types in type of parameter '{0}' doesn't match implemented member '{1}' (possibly because of nullability attributes).";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in type of parameter '{0}' doesn't match implemented member '{1}' (possibly because of nullability attributes).";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
