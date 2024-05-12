namespace dotnet_error_lookup.Data.Errors;

public class CS8428 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8428";
    string IErrorOrWarning.Message => @"Invocation of implicit Index Indexer cannot name the argument.";
    string IErrorOrWarning.Explanation => @"[original] Invocation of implicit Index Indexer cannot name the argument.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
