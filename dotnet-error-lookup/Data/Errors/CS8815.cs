namespace dotnet_error_lookup.Data.Errors;

public class CS8815 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8815";
    string IErrorOrWarning.Message => @"Module initializer method '{0}' must be static, and non-virtual, must have no parameters, and must return 'void'";
    string IErrorOrWarning.Explanation => @"[original] Module initializer method '{0}' must be static, and non-virtual, must have no parameters, and must return 'void'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
