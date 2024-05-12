namespace dotnet_error_lookup.Data.Errors;

public class CS9112 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9112";
    string IErrorOrWarning.Message => @"Anonymous methods, lambda expressions, query expressions, and local functions inside a struct cannot access primary constructor parameter also used inside an instance member";
    string IErrorOrWarning.Explanation => @"[original] Anonymous methods, lambda expressions, query expressions, and local functions inside a struct cannot access primary constructor parameter also used inside an instance member";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
