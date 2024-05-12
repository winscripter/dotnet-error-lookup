namespace dotnet_error_lookup.Data.Errors;

public class CS8142 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8142";
    string IErrorOrWarning.Message => @"Both partial method declarations, '{0}' and '{1}', must use the same tuple element names.";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations, '{0}' and '{1}', must use the same tuple element names.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
