namespace dotnet_error_lookup.Data.Errors;

public class CS0729 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0729";
    string IErrorOrWarning.Message => @"Type '{0}' is defined in this assembly, but a type forwarder is specified for it";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' is defined in this assembly, but a type forwarder is specified for it";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0729";
}
