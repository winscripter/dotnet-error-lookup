namespace dotnet_error_lookup.Data.Errors;

public class CS4024 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS4024";
    string IErrorOrWarning.Message => @"The CallerLineNumberAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments";
    string IErrorOrWarning.Explanation => @"[original] The CallerLineNumberAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
