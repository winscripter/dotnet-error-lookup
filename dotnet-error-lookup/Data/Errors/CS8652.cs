namespace dotnet_error_lookup.Data.Errors;

public class CS8652 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8652";
    string IErrorOrWarning.Message => @"The feature '{0}' is currently in Preview and *unsupported*. To use Preview features, use the 'preview' language version.";
    string IErrorOrWarning.Explanation => @"[original] The feature '{0}' is currently in Preview and \*unsupported\*. To use Preview features, use the 'preview' language version.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
