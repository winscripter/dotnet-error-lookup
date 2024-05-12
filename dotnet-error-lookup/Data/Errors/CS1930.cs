namespace dotnet_error_lookup.Data.Errors;

public class CS1930 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1930";
    string IErrorOrWarning.Message => @"The range variable '{0}' has already been declared";
    string IErrorOrWarning.Explanation => @"[original] The range variable '{0}' has already been declared";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1930";
}
