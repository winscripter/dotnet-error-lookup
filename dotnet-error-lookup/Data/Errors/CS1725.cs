namespace dotnet_error_lookup.Data.Errors;

public class CS1725 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1725";
    string IErrorOrWarning.Message => @"Friend assembly reference '{0}' is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified.";
    string IErrorOrWarning.Explanation => @"[original] Friend assembly reference '{0}' is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1725";
}
