namespace dotnet_error_lookup.Data.Errors;

public class CS1664 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1664";
    string IErrorOrWarning.Message => @"Fixed size buffer of length {0} and type '{1}' is too big";
    string IErrorOrWarning.Explanation => @"[original] Fixed size buffer of length {0} and type '{1}' is too big";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1664";
}
