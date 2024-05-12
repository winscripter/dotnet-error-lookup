namespace dotnet_error_lookup.Data.Errors;

public class CS1028 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1028";
    string IErrorOrWarning.Message => @"Unexpected preprocessor directive";
    string IErrorOrWarning.Explanation => @"[original] Unexpected preprocessor directive";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1028";
}
