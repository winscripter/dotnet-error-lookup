namespace dotnet_error_lookup.Data.Errors;

public class CS8151 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8151";
    string IErrorOrWarning.Message => @"The return expression must be of type '{0}' because this method returns by reference";
    string IErrorOrWarning.Explanation => @"[original] The return expression must be of type '{0}' because this method returns by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8151";
}
