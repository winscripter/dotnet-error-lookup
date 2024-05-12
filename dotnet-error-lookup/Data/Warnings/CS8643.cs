namespace dotnet_error_lookup.Data.Errors;

public class CS8643 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8643";
    string IErrorOrWarning.Message => @"Nullability of reference types in explicit interface specifier doesn't match interface implemented by the type.";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in explicit interface specifier doesn't match interface implemented by the type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
