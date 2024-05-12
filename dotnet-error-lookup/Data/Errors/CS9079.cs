namespace dotnet_error_lookup.Data.Errors;

public class CS9079 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9079";
    string IErrorOrWarning.Message => @"Cannot ref-assign '{1}' to '{0}' because '{1}' can only escape the current method through a return statement.";
    string IErrorOrWarning.Explanation => @"[original] Cannot ref-assign '{1}' to '{0}' because '{1}' can only escape the current method through a return statement.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
