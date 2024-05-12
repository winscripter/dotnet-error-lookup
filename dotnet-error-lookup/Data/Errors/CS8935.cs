namespace dotnet_error_lookup.Data.Errors;

public class CS8935 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8935";
    string IErrorOrWarning.Message => @"The AsyncMethodBuilder attribute is disallowed on anonymous methods without an explicit return type.";
    string IErrorOrWarning.Explanation => @"[original] The AsyncMethodBuilder attribute is disallowed on anonymous methods without an explicit return type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
