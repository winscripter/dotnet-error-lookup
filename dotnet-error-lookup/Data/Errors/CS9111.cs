namespace dotnet_error_lookup.Data.Errors;

public class CS9111 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9111";
    string IErrorOrWarning.Message => @"Anonymous methods, lambda expressions, query expressions, and local functions inside an instance member of a struct cannot access primary constructor parameter";
    string IErrorOrWarning.Explanation => @"[original] Anonymous methods, lambda expressions, query expressions, and local functions inside an instance member of a struct cannot access primary constructor parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
