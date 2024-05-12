namespace dotnet_error_lookup.Data.Errors;

public class CS1940 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1940";
    string IErrorOrWarning.Message => @"Multiple implementations of the query pattern were found for source type '{0}'.  Ambiguous call to '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Multiple implementations of the query pattern were found for source type '{0}'.  Ambiguous call to '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1940";
}
