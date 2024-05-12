namespace dotnet_error_lookup.Data.Errors;

public class CS1555 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1555";
    string IErrorOrWarning.Message => @"Could not find '{0}' specified for Main method";
    string IErrorOrWarning.Explanation => @"[original] Could not find '{0}' specified for Main method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1555";
}
