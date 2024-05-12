namespace dotnet_error_lookup.Data.Errors;

public class CS1514 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1514";
    string IErrorOrWarning.Message => @"{ expected";
    string IErrorOrWarning.Explanation => @"[original] { expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1514";
}
