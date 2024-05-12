namespace dotnet_error_lookup.Data.Errors;

public class CS3027 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3027";
    string IErrorOrWarning.Message => @"'{0}' is not CLS-compliant because base interface '{1}' is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not CLS-compliant because base interface '{1}' is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3027";
}
