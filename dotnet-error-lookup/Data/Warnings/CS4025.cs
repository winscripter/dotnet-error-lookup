namespace dotnet_error_lookup.Data.Errors;

public class CS4025 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS4025";
    string IErrorOrWarning.Message => @"The CallerFilePathAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments";
    string IErrorOrWarning.Explanation => @"[original] The CallerFilePathAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
