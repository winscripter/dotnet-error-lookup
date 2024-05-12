namespace dotnet_error_lookup.Data.Errors;

public class CS0181 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0181";
    string IErrorOrWarning.Message => @"Attribute constructor parameter '{0}' has type '{1}', which is not a valid attribute parameter type";
    string IErrorOrWarning.Explanation => @"[original] Attribute constructor parameter '{0}' has type '{1}', which is not a valid attribute parameter type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0181";
}
