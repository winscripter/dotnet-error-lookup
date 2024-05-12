namespace dotnet_error_lookup.Data.Errors;

public class CS8178 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8178";
    string IErrorOrWarning.Message => @"'await' cannot be used in an expression containing a call to '{0}' because it returns by reference";
    string IErrorOrWarning.Explanation => @"[original] 'await' cannot be used in an expression containing a call to '{0}' because it returns by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8178";
}
