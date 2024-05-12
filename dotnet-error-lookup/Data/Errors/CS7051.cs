namespace dotnet_error_lookup.Data.Errors;

public class CS7051 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7051";
    string IErrorOrWarning.Message => @"SecurityAction value '{0}' is invalid for security attributes applied to a type or a method";
    string IErrorOrWarning.Explanation => @"[original] SecurityAction value '{0}' is invalid for security attributes applied to a type or a method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
