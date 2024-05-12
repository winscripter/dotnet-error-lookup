namespace dotnet_error_lookup.Data.Errors;

public class CS1733 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1733";
    string IErrorOrWarning.Message => @"Expected expression";
    string IErrorOrWarning.Explanation => @"[original] Expected expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1733";
}
