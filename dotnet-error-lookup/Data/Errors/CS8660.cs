namespace dotnet_error_lookup.Data.Errors;

public class CS8660 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8660";
    string IErrorOrWarning.Message => @"Cannot specify 'readonly' modifiers on both property or indexer '{0}' and its accessor. Remove one of them.";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify 'readonly' modifiers on both property or indexer '{0}' and its accessor. Remove one of them.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
