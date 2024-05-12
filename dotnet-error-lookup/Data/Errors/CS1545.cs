namespace dotnet_error_lookup.Data.Errors;

public class CS1545 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1545";
    string IErrorOrWarning.Message => @"Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor methods '{1}' or '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor methods '{1}' or '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1545";
}
