namespace dotnet_error_lookup.Data.Errors;

public class CS8083 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8083";
    string IErrorOrWarning.Message => @"An alias-qualified name is not an expression.";
    string IErrorOrWarning.Explanation => @"[original] An alias-qualified name is not an expression.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
