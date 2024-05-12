namespace dotnet_error_lookup.Data.Errors;

public class CS8959 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8959";
    string IErrorOrWarning.Message => @"CallerArgumentExpressionAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] CallerArgumentExpressionAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
