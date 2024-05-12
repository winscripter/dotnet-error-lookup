namespace dotnet_error_lookup.Data.Errors;

public class CS2005 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2005";
    string IErrorOrWarning.Message => @"Missing file specification for '{0}' option";
    string IErrorOrWarning.Explanation => @"[original] Missing file specification for '{0}' option";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2005";
}
