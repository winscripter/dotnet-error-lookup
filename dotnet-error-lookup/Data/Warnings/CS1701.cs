namespace dotnet_error_lookup.Data.Errors;

public class CS1701 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1701";
    string IErrorOrWarning.Message => @"Assuming assembly reference '{0}' used by '{1}' matches identity '{2}' of '{3}', you may need to supply runtime policy";
    string IErrorOrWarning.Explanation => @"[original] Assuming assembly reference '{0}' used by '{1}' matches identity '{2}' of '{3}', you may need to supply runtime policy";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1701";
}
