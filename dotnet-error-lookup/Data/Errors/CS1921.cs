namespace dotnet_error_lookup.Data.Errors;

public class CS1921 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1921";
    string IErrorOrWarning.Message => @"The best overloaded method match for '{0}' has wrong signature for the initializer element. The initializable Add must be an accessible instance method.";
    string IErrorOrWarning.Explanation => @"[original] The best overloaded method match for '{0}' has wrong signature for the initializer element. The initializable Add must be an accessible instance method.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1921";
}
