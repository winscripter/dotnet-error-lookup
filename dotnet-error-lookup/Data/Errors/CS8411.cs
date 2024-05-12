namespace dotnet_error_lookup.Data.Errors;

public class CS8411 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8411";
    string IErrorOrWarning.Message => @"Asynchronous foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a suitable public instance or extension definition for '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Asynchronous foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a suitable public instance or extension definition for '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8411";
}
