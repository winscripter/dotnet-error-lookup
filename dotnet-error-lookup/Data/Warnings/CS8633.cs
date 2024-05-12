namespace dotnet_error_lookup.Data.Errors;

public class CS8633 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8633";
    string IErrorOrWarning.Message => @"Nullability in constraints for type parameter '{0}' of method '{1}' doesn't match the constraints for type parameter '{2}' of interface method '{3}'. Consider using an explicit interface implementation instead.";
    string IErrorOrWarning.Explanation => @"[original] Nullability in constraints for type parameter '{0}' of method '{1}' doesn't match the constraints for type parameter '{2}' of interface method '{3}'. Consider using an explicit interface implementation instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
