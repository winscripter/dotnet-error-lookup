namespace dotnet_error_lookup.Data.Errors;

public class CS8816 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8816";
    string IErrorOrWarning.Message => @"Module initializer method '{0}' must not be generic and must not be contained in a generic type";
    string IErrorOrWarning.Explanation => @"[original] Module initializer method '{0}' must not be generic and must not be contained in a generic type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
