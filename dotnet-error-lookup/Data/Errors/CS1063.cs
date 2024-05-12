namespace dotnet_error_lookup.Data.Errors;

public class CS1063 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1063";
    string IErrorOrWarning.Message => @"The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}";
    string IErrorOrWarning.Explanation => @"[original] The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1063";
}
