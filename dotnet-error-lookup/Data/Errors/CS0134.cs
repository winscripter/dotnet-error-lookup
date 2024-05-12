namespace dotnet_error_lookup.Data.Errors;

public class CS0134 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0134";
    string IErrorOrWarning.Message => @"'{0}' is of type '{1}'. A const field of a reference type other than string can only be initialized with null.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is of type '{1}'. A const field of a reference type other than string can only be initialized with null.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0134";
}
