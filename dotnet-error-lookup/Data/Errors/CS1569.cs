namespace dotnet_error_lookup.Data.Errors;

public class CS1569 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1569";
    string IErrorOrWarning.Message => @"Error writing to XML documentation file: {0}";
    string IErrorOrWarning.Explanation => @"[original] Error writing to XML documentation file: {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1569";
}
