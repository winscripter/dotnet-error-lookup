namespace dotnet_error_lookup.Data.Errors;

public class CS8174 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8174";
    string IErrorOrWarning.Message => @"A declaration of a by-reference variable must have an initializer";
    string IErrorOrWarning.Explanation => @"[original] A declaration of a by-reference variable must have an initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8174";
}
