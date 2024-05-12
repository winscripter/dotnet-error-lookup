namespace dotnet_error_lookup.Data.Errors;

public class CS0767 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0767";
    string IErrorOrWarning.Message => @"Cannot inherit interface '{0}' with the specified type parameters because it causes method '{1}' to contain overloads which differ only on ref and out";
    string IErrorOrWarning.Explanation => @"[original] Cannot inherit interface '{0}' with the specified type parameters because it causes method '{1}' to contain overloads which differ only on ref and out";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0767";
}
