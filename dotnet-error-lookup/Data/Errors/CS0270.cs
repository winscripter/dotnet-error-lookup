namespace dotnet_error_lookup.Data.Errors;

public class CS0270 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0270";
    string IErrorOrWarning.Message => @"Array size cannot be specified in a variable declaration (try initializing with a 'new' expression)";
    string IErrorOrWarning.Explanation => @"[original] Array size cannot be specified in a variable declaration (try initializing with a 'new' expression)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0270";
}
