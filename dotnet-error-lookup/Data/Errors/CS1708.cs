namespace dotnet_error_lookup.Data.Errors;

public class CS1708 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1708";
    string IErrorOrWarning.Message => @"Fixed size buffers can only be accessed through locals or fields";
    string IErrorOrWarning.Explanation => @"[original] Fixed size buffers can only be accessed through locals or fields";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1708";
}
