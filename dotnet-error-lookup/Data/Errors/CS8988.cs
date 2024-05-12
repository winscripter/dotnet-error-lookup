namespace dotnet_error_lookup.Data.Errors;

public class CS8988 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8988";
    string IErrorOrWarning.Message => @"The 'scoped' modifier of parameter '{0}' doesn't match partial method declaration.";
    string IErrorOrWarning.Explanation => @"[original] The 'scoped' modifier of parameter '{0}' doesn't match partial method declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
