namespace dotnet_error_lookup.Data.Errors;

public class CS0165 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0165";
    string IErrorOrWarning.Message => @"Use of unassigned local variable '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Use of unassigned local variable '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0165";
}
