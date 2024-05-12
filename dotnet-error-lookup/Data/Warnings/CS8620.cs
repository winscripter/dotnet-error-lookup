namespace dotnet_error_lookup.Data.Errors;

public class CS8620 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8620";
    string IErrorOrWarning.Message => @"Argument of type '{0}' cannot be used for parameter '{2}' of type '{1}' in '{3}' due to differences in the nullability of reference types.";
    string IErrorOrWarning.Explanation => @"[original] Argument of type '{0}' cannot be used for parameter '{2}' of type '{1}' in '{3}' due to differences in the nullability of reference types.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
