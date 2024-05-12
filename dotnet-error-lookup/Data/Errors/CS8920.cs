namespace dotnet_error_lookup.Data.Errors;

public class CS8920 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8920";
    string IErrorOrWarning.Message => @"The interface '{0}' cannot be used as type argument. Static member '{1}' does not have a most specific implementation in the interface.";
    string IErrorOrWarning.Explanation => @"[original] The interface '{0}' cannot be used as type argument. Static member '{1}' does not have a most specific implementation in the interface.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
