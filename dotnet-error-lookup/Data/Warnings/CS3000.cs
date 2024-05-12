namespace dotnet_error_lookup.Data.Errors;

public class CS3000 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3000";
    string IErrorOrWarning.Message => @"Methods with variable arguments are not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Methods with variable arguments are not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3000";
}
