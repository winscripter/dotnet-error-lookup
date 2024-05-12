namespace dotnet_error_lookup.Data.Errors;

public class CS1712 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1712";
    string IErrorOrWarning.Message => @"Type parameter '{0}' has no matching typeparam tag in the XML comment on '{1}' (but other type parameters do)";
    string IErrorOrWarning.Explanation => @"[original] Type parameter '{0}' has no matching typeparam tag in the XML comment on '{1}' (but other type parameters do)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1712";
}
