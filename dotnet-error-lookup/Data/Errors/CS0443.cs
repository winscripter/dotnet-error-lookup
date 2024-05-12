namespace dotnet_error_lookup.Data.Errors;

public class CS0443 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0443";
    string IErrorOrWarning.Message => @"Syntax error; value expected";
    string IErrorOrWarning.Explanation => @"[original] Syntax error; value expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0443";
}
