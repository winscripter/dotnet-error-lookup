namespace dotnet_error_lookup.Data.Errors;

public class CS1747 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1747";
    string IErrorOrWarning.Message => @"Cannot embed interop types from assembly '{0}' because it is missing the '{1}' attribute.";
    string IErrorOrWarning.Explanation => @"[original] Cannot embed interop types from assembly '{0}' because it is missing the '{1}' attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
