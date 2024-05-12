namespace dotnet_error_lookup.Data.Errors;

public class CS0724 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0724";
    string IErrorOrWarning.Message => @"A throw statement with no arguments is not allowed in a finally clause that is nested inside the nearest enclosing catch clause";
    string IErrorOrWarning.Explanation => @"[original] A throw statement with no arguments is not allowed in a finally clause that is nested inside the nearest enclosing catch clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0724";
}
