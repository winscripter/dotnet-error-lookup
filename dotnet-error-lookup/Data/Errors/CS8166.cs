namespace dotnet_error_lookup.Data.Errors;

public class CS8166 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8166";
    string IErrorOrWarning.Message => @"Cannot return a parameter by reference '{0}' because it is not a ref parameter";
    string IErrorOrWarning.Explanation => @"[original] Cannot return a parameter by reference '{0}' because it is not a ref parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8166";
}
