namespace dotnet_error_lookup.Data.Errors;

public class CS0052 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0052";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: field type '{1}' is less accessible than field '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: field type '{1}' is less accessible than field '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0052";
}
