namespace dotnet_error_lookup.Data.Errors;

public class CS8852 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8852";
    string IErrorOrWarning.Message => @"Init-only property or indexer '{0}' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.";
    string IErrorOrWarning.Explanation => @"[original] Init-only property or indexer '{0}' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
