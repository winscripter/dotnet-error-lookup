namespace dotnet_error_lookup.Data.Errors;

public class CS0703 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0703";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: constraint type '{1}' is less accessible than '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: constraint type '{1}' is less accessible than '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0703";
}
