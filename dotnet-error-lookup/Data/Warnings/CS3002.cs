namespace dotnet_error_lookup.Data.Errors;

public class CS3002 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3002";
    string IErrorOrWarning.Message => @"Return type of '{0}' is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Return type of '{0}' is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3002";
}
