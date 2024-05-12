namespace dotnet_error_lookup.Data.Errors;

public class CS0304 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0304";
    string IErrorOrWarning.Message => @"Cannot create an instance of the variable type '{0}' because it does not have the new() constraint";
    string IErrorOrWarning.Explanation => @"[original] Cannot create an instance of the variable type '{0}' because it does not have the new() constraint";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0304";
}
