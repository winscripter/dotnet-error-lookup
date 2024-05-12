namespace dotnet_error_lookup.Data.Errors;

public class CS7012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7012";
    string IErrorOrWarning.Message => @"The name '{0}' does not exist in the current context (are you missing a reference to assembly '{1}'?)";
    string IErrorOrWarning.Explanation => @"[original] The name '{0}' does not exist in the current context (are you missing a reference to assembly '{1}'?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
