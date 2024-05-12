namespace dotnet_error_lookup.Data.Errors;

public class CS1759 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1759";
    string IErrorOrWarning.Message => @"Cannot embed interop types from assembly '{0}' because it is missing either the '{1}' attribute or the '{2}' attribute.";
    string IErrorOrWarning.Explanation => @"[original] Cannot embed interop types from assembly '{0}' because it is missing either the '{1}' attribute or the '{2}' attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
