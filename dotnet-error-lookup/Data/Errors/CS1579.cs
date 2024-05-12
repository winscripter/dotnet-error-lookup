namespace dotnet_error_lookup.Data.Errors;

public class CS1579 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1579";
    string IErrorOrWarning.Message => @"foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'";
    string IErrorOrWarning.Explanation => @"[original] foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1579";
}
