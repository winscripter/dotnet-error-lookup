namespace dotnet_error_lookup.Data.Errors;

public class CS8329 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8329";
    string IErrorOrWarning.Message => @"Cannot use {0} '{1}' as a ref or out value because it is a readonly variable";
    string IErrorOrWarning.Explanation => @"[original] Cannot use {0} '{1}' as a ref or out value because it is a readonly variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
