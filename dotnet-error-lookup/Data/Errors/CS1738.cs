namespace dotnet_error_lookup.Data.Errors;

public class CS1738 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1738";
    string IErrorOrWarning.Message => @"Named argument specifications must appear after all fixed arguments have been specified. Please use language version {0} or greater to allow non-trailing named arguments.";
    string IErrorOrWarning.Explanation => @"[original] Named argument specifications must appear after all fixed arguments have been specified. Please use language version {0} or greater to allow non-trailing named arguments.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
