namespace dotnet_error_lookup.Data.Errors;

public class CS1700 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1700";
    string IErrorOrWarning.Message => @"Assembly reference '{0}' is invalid and cannot be resolved";
    string IErrorOrWarning.Explanation => @"[original] Assembly reference '{0}' is invalid and cannot be resolved";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1700";
}
