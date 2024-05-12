namespace dotnet_error_lookup.Data.Errors;

public class CS8611 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8611";
    string IErrorOrWarning.Message => @"Nullability of reference types in type of parameter '{0}' doesn't match partial method declaration.";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in type of parameter '{0}' doesn't match partial method declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
