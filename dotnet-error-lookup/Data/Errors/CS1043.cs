namespace dotnet_error_lookup.Data.Errors;

public class CS1043 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1043";
    string IErrorOrWarning.Message => @"{ or ; expected";
    string IErrorOrWarning.Explanation => @"[original] { or ; expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1043";
}
