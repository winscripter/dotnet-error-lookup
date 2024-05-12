namespace dotnet_error_lookup.Data.Errors;

public class CS1935 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1935";
    string IErrorOrWarning.Message => @"Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Are you missing required assembly references or a using directive for 'System.Linq'?";
    string IErrorOrWarning.Explanation => @"[original] Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Are you missing required assembly references or a using directive for 'System.Linq'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1935";
}
