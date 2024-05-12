namespace dotnet_error_lookup.Data.Errors;

public class CS1665 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1665";
    string IErrorOrWarning.Message => @"Fixed size buffers must have a length greater than zero";
    string IErrorOrWarning.Explanation => @"[original] Fixed size buffers must have a length greater than zero";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1665";
}
