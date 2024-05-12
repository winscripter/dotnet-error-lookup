namespace dotnet_error_lookup.Data.Errors;

public class CS8517 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8517";
    string IErrorOrWarning.Message => @"The name '{0}' does not match the corresponding 'Deconstruct' parameter '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The name '{0}' does not match the corresponding 'Deconstruct' parameter '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
