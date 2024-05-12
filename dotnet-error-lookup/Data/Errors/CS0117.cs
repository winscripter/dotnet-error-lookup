namespace dotnet_error_lookup.Data.Errors;

public class CS0117 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0117";
    string IErrorOrWarning.Message => @"'{0}' does not contain a definition for '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not contain a definition for '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0117";
}
