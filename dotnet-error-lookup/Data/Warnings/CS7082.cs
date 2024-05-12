namespace dotnet_error_lookup.Data.Errors;

public class CS7082 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7082";
    string IErrorOrWarning.Message => @"The CallerFilePathAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.";
    string IErrorOrWarning.Explanation => @"[original] The CallerFilePathAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
