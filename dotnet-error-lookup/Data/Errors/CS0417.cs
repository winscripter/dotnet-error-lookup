namespace dotnet_error_lookup.Data.Errors;

public class CS0417 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0417";
    string IErrorOrWarning.Message => @"'{0}': cannot provide arguments when creating an instance of a variable type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot provide arguments when creating an instance of a variable type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0417";
}
