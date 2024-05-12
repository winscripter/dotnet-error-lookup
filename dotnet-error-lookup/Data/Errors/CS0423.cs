namespace dotnet_error_lookup.Data.Errors;

public class CS0423 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0423";
    string IErrorOrWarning.Message => @"Since '{1}' has the ComImport attribute, '{0}' must be extern or abstract";
    string IErrorOrWarning.Explanation => @"[original] Since '{1}' has the ComImport attribute, '{0}' must be extern or abstract";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0423";
}
