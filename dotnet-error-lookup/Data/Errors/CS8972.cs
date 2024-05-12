namespace dotnet_error_lookup.Data.Errors;

public class CS8972 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8972";
    string IErrorOrWarning.Message => @"A lambda expression with attributes cannot be converted to an expression tree";
    string IErrorOrWarning.Explanation => @"[original] A lambda expression with attributes cannot be converted to an expression tree";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
