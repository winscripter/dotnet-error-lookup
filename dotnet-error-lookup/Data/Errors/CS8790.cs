namespace dotnet_error_lookup.Data.Errors;

public class CS8790 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8790";
    string IErrorOrWarning.Message => @"An expression tree may not contain a pattern System.Index or System.Range indexer access";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a pattern System.Index or System.Range indexer access";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
