namespace dotnet_error_lookup.Data.Errors;

public class CS0236 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0236";
    string IErrorOrWarning.Message => @"A field initializer cannot reference the non-static field, method, or property '{0}'";
    string IErrorOrWarning.Explanation => @"[original] A field initializer cannot reference the non-static field, method, or property '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0236";
}
