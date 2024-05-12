namespace dotnet_error_lookup.Data.Errors;

public class CS9011 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9011";
    string IErrorOrWarning.Message => @"Keyword 'delegate' cannot be used as a constraint. Did you mean 'System.Delegate'?";
    string IErrorOrWarning.Explanation => @"[original] Keyword 'delegate' cannot be used as a constraint. Did you mean 'System.Delegate'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
