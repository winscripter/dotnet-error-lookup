namespace dotnet_error_lookup.Data.Errors;

public class CS0120 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0120";
    string IErrorOrWarning.Message => @"An object reference is required for the non-static field, method, or property '{0}'";
    string IErrorOrWarning.Explanation => @"[original] An object reference is required for the non-static field, method, or property '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0120";
}
