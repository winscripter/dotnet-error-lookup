namespace dotnet_error_lookup.Data.Errors;

public class CS9035 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9035";
    string IErrorOrWarning.Message => @"Required member '{0}' must be set in the object initializer or attribute constructor.";
    string IErrorOrWarning.Explanation => @"[original] Required member '{0}' must be set in the object initializer or attribute constructor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
