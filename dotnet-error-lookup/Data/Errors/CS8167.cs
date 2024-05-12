namespace dotnet_error_lookup.Data.Errors;

public class CS8167 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8167";
    string IErrorOrWarning.Message => @"Cannot return by reference a member of parameter '{0}' because it is not a ref or out parameter";
    string IErrorOrWarning.Explanation => @"[original] Cannot return by reference a member of parameter '{0}' because it is not a ref or out parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8167";
}
