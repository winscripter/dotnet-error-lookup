namespace dotnet_error_lookup.Data.Errors;

public class CS1934 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1934";
    string IErrorOrWarning.Message => @"Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Consider explicitly specifying the type of the range variable '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Consider explicitly specifying the type of the range variable '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1934";
}
