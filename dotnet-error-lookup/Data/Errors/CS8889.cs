namespace dotnet_error_lookup.Data.Errors;

public class CS8889 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8889";
    string IErrorOrWarning.Message => @"The target runtime doesn't support extensible or runtime-environment default calling conventions.";
    string IErrorOrWarning.Explanation => @"[original] The target runtime doesn't support extensible or runtime-environment default calling conventions.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
