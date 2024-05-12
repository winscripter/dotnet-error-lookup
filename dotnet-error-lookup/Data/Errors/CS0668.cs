namespace dotnet_error_lookup.Data.Errors;

public class CS0668 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0668";
    string IErrorOrWarning.Message => @"Two indexers have different names; the IndexerName attribute must be used with the same name on every indexer within a type";
    string IErrorOrWarning.Explanation => @"[original] Two indexers have different names; the IndexerName attribute must be used with the same name on every indexer within a type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0668";
}
