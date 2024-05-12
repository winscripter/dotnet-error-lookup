namespace dotnet_error_lookup.Data.Errors;

public class CS9025 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9025";
    string IErrorOrWarning.Message => @"The operator '{0}' requires a matching non-checked version of the operator to also be defined";
    string IErrorOrWarning.Explanation => @"[original] The operator '{0}' requires a matching non-checked version of the operator to also be defined";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
