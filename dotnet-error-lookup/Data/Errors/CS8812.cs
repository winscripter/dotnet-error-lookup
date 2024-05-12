namespace dotnet_error_lookup.Data.Errors;

public class CS8812 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8812";
    string IErrorOrWarning.Message => @"Cannot convert &method group '{0}' to non-function pointer type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert &method group '{0}' to non-function pointer type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8812";
}
