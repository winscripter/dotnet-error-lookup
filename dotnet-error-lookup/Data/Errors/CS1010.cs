namespace dotnet_error_lookup.Data.Errors;

public class CS1010 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1010";
    string IErrorOrWarning.Message => @"Newline in constant";
    string IErrorOrWarning.Explanation => @"[original] Newline in constant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1010";
}
