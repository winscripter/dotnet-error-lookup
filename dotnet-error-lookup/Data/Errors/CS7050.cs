namespace dotnet_error_lookup.Data.Errors;

public class CS7050 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7050";
    string IErrorOrWarning.Message => @"SecurityAction value '{0}' is invalid for security attributes applied to an assembly";
    string IErrorOrWarning.Explanation => @"[original] SecurityAction value '{0}' is invalid for security attributes applied to an assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
