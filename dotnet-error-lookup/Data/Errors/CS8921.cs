namespace dotnet_error_lookup.Data.Errors;

public class CS8921 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8921";
    string IErrorOrWarning.Message => @"The parameter of a unary operator must be the containing type, or its type parameter constrained to it.";
    string IErrorOrWarning.Explanation => @"[original] The parameter of a unary operator must be the containing type, or its type parameter constrained to it.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
