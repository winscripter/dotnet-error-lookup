namespace dotnet_error_lookup.Data.Errors;

public class CS0655 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0655";
    string IErrorOrWarning.Message => @"'{0}' is not a valid named attribute argument because it is not a valid attribute parameter type";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a valid named attribute argument because it is not a valid attribute parameter type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0655";
}
