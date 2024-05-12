namespace dotnet_error_lookup.Data.Errors;

public class CS1679 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1679";
    string IErrorOrWarning.Message => @"Invalid extern alias for '/reference'; '{0}' is not a valid identifier";
    string IErrorOrWarning.Explanation => @"[original] Invalid extern alias for '/reference'; '{0}' is not a valid identifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1679";
}
