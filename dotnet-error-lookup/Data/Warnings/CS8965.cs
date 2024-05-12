namespace dotnet_error_lookup.Data.Errors;

public class CS8965 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8965";
    string IErrorOrWarning.Message => @"The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect because it's self-referential.";
    string IErrorOrWarning.Explanation => @"[original] The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect because it's self-referential.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
