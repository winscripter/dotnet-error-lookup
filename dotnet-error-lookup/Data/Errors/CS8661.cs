namespace dotnet_error_lookup.Data.Errors;

public class CS8661 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8661";
    string IErrorOrWarning.Message => @"Cannot specify 'readonly' modifiers on both accessors of property or indexer '{0}'. Instead, put a 'readonly' modifier on the property itself.";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify 'readonly' modifiers on both accessors of property or indexer '{0}'. Instead, put a 'readonly' modifier on the property itself.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
