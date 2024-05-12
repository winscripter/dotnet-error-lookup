namespace dotnet_error_lookup.Data.Errors;

public class CS1762 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1762";
    string IErrorOrWarning.Message => @"A reference was created to embedded interop assembly '{0}' because of an indirect reference to that assembly created by assembly '{1}'. Consider changing the 'Embed Interop Types' property on either assembly.";
    string IErrorOrWarning.Explanation => @"[original] A reference was created to embedded interop assembly '{0}' because of an indirect reference to that assembly created by assembly '{1}'. Consider changing the 'Embed Interop Types' property on either assembly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1762";
}
