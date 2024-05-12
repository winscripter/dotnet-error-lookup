namespace dotnet_error_lookup.Data.Errors;

public class CS0029 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0029";
    string IErrorOrWarning.Message => @"Cannot implicitly convert type '{0}' to '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot implicitly convert type '{0}' to '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0029";
}
