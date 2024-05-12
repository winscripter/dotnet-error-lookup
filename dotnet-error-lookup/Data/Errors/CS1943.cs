namespace dotnet_error_lookup.Data.Errors;

public class CS1943 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1943";
    string IErrorOrWarning.Message => @"An expression of type '{0}' is not allowed in a subsequent from clause in a query expression with source type '{1}'.  Type inference failed in the call to '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] An expression of type '{0}' is not allowed in a subsequent from clause in a query expression with source type '{1}'.  Type inference failed in the call to '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1943";
}
