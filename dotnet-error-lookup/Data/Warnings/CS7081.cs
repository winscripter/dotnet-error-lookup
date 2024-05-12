namespace dotnet_error_lookup.Data.Errors;

public class CS7081 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7081";
    string IErrorOrWarning.Message => @"The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.";
    string IErrorOrWarning.Explanation => @"[original] The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
