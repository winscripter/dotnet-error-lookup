namespace dotnet_error_lookup.Data.Errors;

public class CS8361 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8361";
    string IErrorOrWarning.Message => @"A conditional expression cannot be used directly in a string interpolation because the ':' ends the interpolation. Parenthesize the conditional expression.";
    string IErrorOrWarning.Explanation => @"[original] A conditional expression cannot be used directly in a string interpolation because the ':' ends the interpolation. Parenthesize the conditional expression.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
