namespace dotnet_error_lookup.Data.Errors;

public class CS4008 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4008";
    string IErrorOrWarning.Message => @"Cannot await 'void'";
    string IErrorOrWarning.Explanation => @"[original] Cannot await 'void'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4008";
}
