namespace dotnet_error_lookup.Data.Errors;

public class CS8622 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8622";
    string IErrorOrWarning.Message => @"Nullability of reference types in type of parameter '{0}' of '{1}' doesn't match the target delegate '{2}' (possibly because of nullability attributes).";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in type of parameter '{0}' of '{1}' doesn't match the target delegate '{2}' (possibly because of nullability attributes).";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
