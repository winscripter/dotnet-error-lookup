namespace dotnet_error_lookup.Data.Errors;

public class CS8371 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8371";
    string IErrorOrWarning.Message => @"Field-targeted attributes on auto-properties are not supported in language version {0}. Please use language version {1} or greater.";
    string IErrorOrWarning.Explanation => @"[original] Field-targeted attributes on auto-properties are not supported in language version {0}. Please use language version {1} or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
