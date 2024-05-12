namespace dotnet_error_lookup.Data.Errors;

public class CS1546 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1546";
    string IErrorOrWarning.Message => @"Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor method '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor method '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1546";
}
