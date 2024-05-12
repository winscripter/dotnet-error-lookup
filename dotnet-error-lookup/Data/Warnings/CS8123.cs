namespace dotnet_error_lookup.Data.Errors;

public class CS8123 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8123";
    string IErrorOrWarning.Message => @"The tuple element name '{0}' is ignored because a different name or no name is specified by the target type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The tuple element name '{0}' is ignored because a different name or no name is specified by the target type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
