namespace dotnet_error_lookup.Data.Errors;

public class CS3016 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3016";
    string IErrorOrWarning.Message => @"Arrays as attribute arguments is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Arrays as attribute arguments is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3016";
}
