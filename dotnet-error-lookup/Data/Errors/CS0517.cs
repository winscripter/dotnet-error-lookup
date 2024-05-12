namespace dotnet_error_lookup.Data.Errors;

public class CS0517 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0517";
    string IErrorOrWarning.Message => @"'{0}' has no base class and cannot call a base constructor";
    string IErrorOrWarning.Explanation => @"[original] '{0}' has no base class and cannot call a base constructor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0517";
}
