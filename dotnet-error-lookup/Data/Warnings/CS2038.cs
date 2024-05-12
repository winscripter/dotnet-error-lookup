namespace dotnet_error_lookup.Data.Errors;

public class CS2038 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS2038";
    string IErrorOrWarning.Message => @"The language name '{0}' is invalid.";
    string IErrorOrWarning.Explanation => @"[original] The language name '{0}' is invalid.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
