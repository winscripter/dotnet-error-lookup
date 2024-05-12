namespace dotnet_error_lookup.Data.Errors;

public class CS8173 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8173";
    string IErrorOrWarning.Message => @"The expression must be of type '{0}' because it is being assigned by reference";
    string IErrorOrWarning.Explanation => @"[original] The expression must be of type '{0}' because it is being assigned by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8173";
}
