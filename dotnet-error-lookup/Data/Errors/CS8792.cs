namespace dotnet_error_lookup.Data.Errors;

public class CS8792 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8792";
    string IErrorOrWarning.Message => @"An expression tree may not contain a range ('..') expression.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a range ('..') expression.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
