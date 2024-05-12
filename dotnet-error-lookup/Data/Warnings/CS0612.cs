namespace dotnet_error_lookup.Data.Errors;

public class CS0612 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0612";
    string IErrorOrWarning.Message => @"'{0}' is obsolete";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is obsolete";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0612";
}
