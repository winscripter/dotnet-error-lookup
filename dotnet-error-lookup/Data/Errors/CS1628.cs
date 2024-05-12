namespace dotnet_error_lookup.Data.Errors;

public class CS1628 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1628";
    string IErrorOrWarning.Message => @"Cannot use ref, out, or in parameter '{0}' inside an anonymous method, lambda expression, query expression, or local function";
    string IErrorOrWarning.Explanation => @"[original] Cannot use ref, out, or in parameter '{0}' inside an anonymous method, lambda expression, query expression, or local function";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1628";
}
