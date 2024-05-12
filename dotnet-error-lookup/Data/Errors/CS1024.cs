namespace dotnet_error_lookup.Data.Errors;

public class CS1024 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1024";
    string IErrorOrWarning.Message => @"Preprocessor directive expected";
    string IErrorOrWarning.Explanation => @"[original] Preprocessor directive expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1024";
}
