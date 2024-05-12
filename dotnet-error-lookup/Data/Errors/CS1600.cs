namespace dotnet_error_lookup.Data.Errors;

public class CS1600 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1600";
    string IErrorOrWarning.Message => @"Compilation cancelled by user";
    string IErrorOrWarning.Explanation => @"[original] Compilation cancelled by user";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1600";
}
