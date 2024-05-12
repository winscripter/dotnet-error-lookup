namespace dotnet_error_lookup.Data.Errors;

public class CS1900 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1900";
    string IErrorOrWarning.Message => @"Warning level must be zero or greater";
    string IErrorOrWarning.Explanation => @"[original] Warning level must be zero or greater";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1900";
}
