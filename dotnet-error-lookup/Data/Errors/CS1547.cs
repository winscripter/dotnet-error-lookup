namespace dotnet_error_lookup.Data.Errors;

public class CS1547 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1547";
    string IErrorOrWarning.Message => @"Keyword 'void' cannot be used in this context";
    string IErrorOrWarning.Explanation => @"[original] Keyword 'void' cannot be used in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1547";
}
