namespace dotnet_error_lookup.Data.Errors;

public class CS8154 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8154";
    string IErrorOrWarning.Message => @"The body of '{0}' cannot be an iterator block because '{0}' returns by reference";
    string IErrorOrWarning.Explanation => @"[original] The body of '{0}' cannot be an iterator block because '{0}' returns by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8154";
}
