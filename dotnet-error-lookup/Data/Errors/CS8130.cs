namespace dotnet_error_lookup.Data.Errors;

public class CS8130 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8130";
    string IErrorOrWarning.Message => @"Cannot infer the type of implicitly-typed deconstruction variable '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot infer the type of implicitly-typed deconstruction variable '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8130";
}
