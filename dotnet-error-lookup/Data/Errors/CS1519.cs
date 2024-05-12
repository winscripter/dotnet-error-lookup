namespace dotnet_error_lookup.Data.Errors;

public class CS1519 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1519";
    string IErrorOrWarning.Message => @"Invalid token '{0}' in class, record, struct, or interface member declaration";
    string IErrorOrWarning.Explanation => @"[original] Invalid token '{0}' in class, record, struct, or interface member declaration";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1519";
}
