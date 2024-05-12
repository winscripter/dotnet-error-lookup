namespace dotnet_error_lookup.Data.Errors;

public class CS1729 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1729";
    string IErrorOrWarning.Message => @"'{0}' does not contain a constructor that takes {1} arguments";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not contain a constructor that takes {1} arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1729";
}
