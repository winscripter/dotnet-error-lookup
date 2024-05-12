namespace dotnet_error_lookup.Data.Errors;

public class CS1996 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1996";
    string IErrorOrWarning.Message => @"Cannot await in the body of a lock statement";
    string IErrorOrWarning.Explanation => @"[original] Cannot await in the body of a lock statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1996";
}
