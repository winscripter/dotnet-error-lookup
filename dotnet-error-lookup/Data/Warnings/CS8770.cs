namespace dotnet_error_lookup.Data.Errors;

public class CS8770 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8770";
    string IErrorOrWarning.Message => @"Method '{0}' lacks `[DoesNotReturn]` annotation to match implemented or overridden member.";
    string IErrorOrWarning.Explanation => @"[original] Method '{0}' lacks `[DoesNotReturn]` annotation to match implemented or overridden member.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
