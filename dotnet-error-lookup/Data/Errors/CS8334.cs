namespace dotnet_error_lookup.Data.Errors;

public class CS8334 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8334";
    string IErrorOrWarning.Message => @"Members of {0} '{1}' cannot be returned by writable reference because it is a readonly variable";
    string IErrorOrWarning.Explanation => @"[original] Members of {0} '{1}' cannot be returned by writable reference because it is a readonly variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8334";
}
