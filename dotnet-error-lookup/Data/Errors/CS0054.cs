namespace dotnet_error_lookup.Data.Errors;

public class CS0054 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0054";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: indexer return type '{1}' is less accessible than indexer '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: indexer return type '{1}' is less accessible than indexer '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0054";
}
