namespace dotnet_error_lookup.Data.Errors;

public class CS1585 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1585";
    string IErrorOrWarning.Message => @"Member modifier '{0}' must precede the member type and name";
    string IErrorOrWarning.Explanation => @"[original] Member modifier '{0}' must precede the member type and name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1585";
}
