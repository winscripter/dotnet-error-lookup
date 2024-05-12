namespace dotnet_error_lookup.Data.Errors;

public class CS7027 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7027";
    string IErrorOrWarning.Message => @"Error signing output with public key from file '{0}' -- {1}";
    string IErrorOrWarning.Explanation => @"[original] Error signing output with public key from file '{0}' -- {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
