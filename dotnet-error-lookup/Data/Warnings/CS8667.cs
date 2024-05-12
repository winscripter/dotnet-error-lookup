namespace dotnet_error_lookup.Data.Errors;

public class CS8667 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8667";
    string IErrorOrWarning.Message => @"Partial method declarations of '{0}' have inconsistent nullability in constraints for type parameter '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Partial method declarations of '{0}' have inconsistent nullability in constraints for type parameter '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
