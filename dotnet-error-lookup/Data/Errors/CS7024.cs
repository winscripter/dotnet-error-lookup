namespace dotnet_error_lookup.Data.Errors;

public class CS7024 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7024";
    string IErrorOrWarning.Message => @"Delegate '{0}' has no invoke method or an invoke method with a return type or parameter types that are not supported.";
    string IErrorOrWarning.Explanation => @"[original] Delegate '{0}' has no invoke method or an invoke method with a return type or parameter types that are not supported.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
