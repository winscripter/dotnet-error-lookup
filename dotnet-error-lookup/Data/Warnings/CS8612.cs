namespace dotnet_error_lookup.Data.Errors;

public class CS8612 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8612";
    string IErrorOrWarning.Message => @"Nullability of reference types in type of '{0}' doesn't match implicitly implemented member '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in type of '{0}' doesn't match implicitly implemented member '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
