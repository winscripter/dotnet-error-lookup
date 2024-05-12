namespace dotnet_error_lookup.Data.Errors;

public class CS1949 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1949";
    string IErrorOrWarning.Message => @"The contextual keyword 'var' cannot be used in a range variable declaration";
    string IErrorOrWarning.Explanation => @"[original] The contextual keyword 'var' cannot be used in a range variable declaration";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1949";
}
