namespace dotnet_error_lookup.Data.Errors;

public class CS1504 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1504";
    string IErrorOrWarning.Message => @"Source file '{0}' could not be opened -- {1}";
    string IErrorOrWarning.Explanation => @"[original] Source file '{0}' could not be opened -- {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1504";
}
