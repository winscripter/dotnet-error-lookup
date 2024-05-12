namespace dotnet_error_lookup.Data.Errors;

public class CS0731 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0731";
    string IErrorOrWarning.Message => @"The type forwarder for type '{0}' in assembly '{1}' causes a cycle";
    string IErrorOrWarning.Explanation => @"[original] The type forwarder for type '{0}' in assembly '{1}' causes a cycle";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0731";
}
