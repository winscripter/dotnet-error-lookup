namespace dotnet_error_lookup.Data.Errors;

public class CS4026 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS4026";
    string IErrorOrWarning.Message => @"The CallerMemberNameAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments";
    string IErrorOrWarning.Explanation => @"[original] The CallerMemberNameAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
