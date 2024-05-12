namespace dotnet_error_lookup.Data.Errors;

public class CS8759 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8759";
    string IErrorOrWarning.Message => @"Cannot create a function pointer for '{0}' because it is not a static method";
    string IErrorOrWarning.Explanation => @"[original] Cannot create a function pointer for '{0}' because it is not a static method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
