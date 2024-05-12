namespace dotnet_error_lookup.Data.Errors;

public class CS0019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0019";
    string IErrorOrWarning.Message => @"Operator '{0}' cannot be applied to operands of type '{1}' and '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' cannot be applied to operands of type '{1}' and '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0019";
}
