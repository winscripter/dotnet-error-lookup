namespace dotnet_error_lookup.Data.Errors;

public class CS1040 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1040";
    string IErrorOrWarning.Message => @"Preprocessor directives must appear as the first non-whitespace character on a line";
    string IErrorOrWarning.Explanation => @"[original] Preprocessor directives must appear as the first non-whitespace character on a line";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1040";
}
