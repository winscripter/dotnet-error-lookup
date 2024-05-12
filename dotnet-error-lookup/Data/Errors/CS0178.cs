namespace dotnet_error_lookup.Data.Errors;

public class CS0178 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0178";
    string IErrorOrWarning.Message => @"Invalid rank specifier: expected ',' or ']'";
    string IErrorOrWarning.Explanation => @"[original] Invalid rank specifier: expected ',' or ']'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0178";
}
