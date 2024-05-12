namespace dotnet_error_lookup.Data.Errors;

public class CS0163 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0163";
    string IErrorOrWarning.Message => @"Control cannot fall through from one case label ('{0}') to another";
    string IErrorOrWarning.Explanation => @"[original] Control cannot fall through from one case label ('{0}') to another";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0163";
}
