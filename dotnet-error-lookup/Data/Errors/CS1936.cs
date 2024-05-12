namespace dotnet_error_lookup.Data.Errors;

public class CS1936 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1936";
    string IErrorOrWarning.Message => @"Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.";
    string IErrorOrWarning.Explanation => @"[original] Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1936";
}
