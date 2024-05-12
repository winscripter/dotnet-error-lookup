namespace dotnet_error_lookup.Data.Errors;

public class CS1551 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1551";
    string IErrorOrWarning.Message => @"Indexers must have at least one parameter";
    string IErrorOrWarning.Explanation => @"[original] Indexers must have at least one parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1551";
}
