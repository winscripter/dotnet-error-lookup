namespace dotnet_error_lookup.Data.Errors;

public class CS0702 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0702";
    string IErrorOrWarning.Message => @"Constraint cannot be special class '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Constraint cannot be special class '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0702";
}
