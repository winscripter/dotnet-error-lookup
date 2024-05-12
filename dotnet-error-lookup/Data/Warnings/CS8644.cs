namespace dotnet_error_lookup.Data.Errors;

public class CS8644 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8644";
    string IErrorOrWarning.Message => @"'{0}' does not implement interface member '{1}'. Nullability of reference types in interface implemented by the base type doesn't match.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement interface member '{1}'. Nullability of reference types in interface implemented by the base type doesn't match.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
