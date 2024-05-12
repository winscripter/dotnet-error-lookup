namespace dotnet_error_lookup.Data.Errors;

public class CS1004 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1004";
    string IErrorOrWarning.Message => @"Duplicate '{0}' modifier";
    string IErrorOrWarning.Explanation => @"[original] Duplicate '{0}' modifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1004";
}
