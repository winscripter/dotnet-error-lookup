namespace dotnet_error_lookup.Data.Errors;

public class CS8964 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8964";
    string IErrorOrWarning.Message => @"The CallerArgumentExpressionAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.Explanation => @"[original] The CallerArgumentExpressionAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
