namespace dotnet_error_lookup.Data.Errors;

public class CS8624 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8624";
    string IErrorOrWarning.Message => @"Argument of type '{0}' cannot be used as an output of type '{1}' for parameter '{2}' in '{3}' due to differences in the nullability of reference types.";
    string IErrorOrWarning.Explanation => @"[original] Argument of type '{0}' cannot be used as an output of type '{1}' for parameter '{2}' in '{3}' due to differences in the nullability of reference types.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
