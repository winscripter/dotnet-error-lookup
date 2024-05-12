namespace dotnet_error_lookup.Data.Errors;

public class CS1726 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1726";
    string IErrorOrWarning.Message => @"Friend assembly reference '{0}' is invalid. Strong-name signed assemblies must specify a public key in their InternalsVisibleTo declarations.";
    string IErrorOrWarning.Explanation => @"[original] Friend assembly reference '{0}' is invalid. Strong-name signed assemblies must specify a public key in their InternalsVisibleTo declarations.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1726";
}
