namespace dotnet_error_lookup.Data.Errors;

public class CS4020 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4020";
    string IErrorOrWarning.Message => @"The CallerLineNumberAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.Explanation => @"[original] The CallerLineNumberAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
