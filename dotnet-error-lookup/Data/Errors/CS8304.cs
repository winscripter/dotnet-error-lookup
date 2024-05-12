namespace dotnet_error_lookup.Data.Errors;

public class CS8304 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8304";
    string IErrorOrWarning.Message => @"Compiler version: '{0}'. Language version: {1}.";
    string IErrorOrWarning.Explanation => @"[original] Compiler version: '{0}'. Language version: {1}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
