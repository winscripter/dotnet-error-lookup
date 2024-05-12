namespace dotnet_error_lookup.Data.Errors;

public class CS0694 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0694";
    string IErrorOrWarning.Message => @"Type parameter '{0}' has the same name as the containing type, or method";
    string IErrorOrWarning.Explanation => @"[original] Type parameter '{0}' has the same name as the containing type, or method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0694";
}
