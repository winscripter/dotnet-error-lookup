namespace dotnet_error_lookup.Data.Errors;

public class CS8011 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8011";
    string IErrorOrWarning.Message => @"Assembly and module '{0}' cannot target different processors.";
    string IErrorOrWarning.Explanation => @"[original] Assembly and module '{0}' cannot target different processors.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
