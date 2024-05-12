namespace dotnet_error_lookup.Data.Errors;

public class CS8963 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8963";
    string IErrorOrWarning.Message => @"The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect. It is applied with an invalid parameter name.";
    string IErrorOrWarning.Explanation => @"[original] The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect. It is applied with an invalid parameter name.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
