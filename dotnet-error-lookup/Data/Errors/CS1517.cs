namespace dotnet_error_lookup.Data.Errors;

public class CS1517 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1517";
    string IErrorOrWarning.Message => @"Invalid preprocessor expression";
    string IErrorOrWarning.Explanation => @"[original] Invalid preprocessor expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1517";
}
