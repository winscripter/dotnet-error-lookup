namespace dotnet_error_lookup.Data.Errors;

public class CS9107 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9107";
    string IErrorOrWarning.Message => @"Parameter '{0}' is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
