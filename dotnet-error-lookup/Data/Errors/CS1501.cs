namespace dotnet_error_lookup.Data.Errors;

public class CS1501 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1501";
    string IErrorOrWarning.Message => @"No overload for method '{0}' takes {1} arguments";
    string IErrorOrWarning.Explanation => @"[original] No overload for method '{0}' takes {1} arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1501";
}
