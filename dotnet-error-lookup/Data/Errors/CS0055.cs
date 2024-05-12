namespace dotnet_error_lookup.Data.Errors;

public class CS0055 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0055";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: parameter type '{1}' is less accessible than indexer '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: parameter type '{1}' is less accessible than indexer '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0055";
}
