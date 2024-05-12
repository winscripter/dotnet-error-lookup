namespace dotnet_error_lookup.Data.Errors;

public class CS8619 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8619";
    string IErrorOrWarning.Message => @"Nullability of reference types in value of type '{0}' doesn't match target type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in value of type '{0}' doesn't match target type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
