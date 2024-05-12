namespace dotnet_error_lookup.Data.Errors;

public class CS1576 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1576";
    string IErrorOrWarning.Message => @"The line number specified for #line directive is missing or invalid";
    string IErrorOrWarning.Explanation => @"[original] The line number specified for #line directive is missing or invalid";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1576";
}
