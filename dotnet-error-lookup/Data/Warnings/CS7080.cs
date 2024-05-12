namespace dotnet_error_lookup.Data.Errors;

public class CS7080 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7080";
    string IErrorOrWarning.Message => @"The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerFilePathAttribute.";
    string IErrorOrWarning.Explanation => @"[original] The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerFilePathAttribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
