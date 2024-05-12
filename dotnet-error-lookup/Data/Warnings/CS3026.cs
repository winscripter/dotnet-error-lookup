namespace dotnet_error_lookup.Data.Errors;

public class CS3026 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3026";
    string IErrorOrWarning.Message => @"CLS-compliant field '{0}' cannot be volatile";
    string IErrorOrWarning.Explanation => @"[original] CLS-compliant field '{0}' cannot be volatile";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3026";
}
