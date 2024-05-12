namespace dotnet_error_lookup.Data.Errors;

public class CS0006 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0006";
    string IErrorOrWarning.Message => @"Metadata file '{0}' could not be found";
    string IErrorOrWarning.Explanation => @"[original] Metadata file '{0}' could not be found";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0006";
}
