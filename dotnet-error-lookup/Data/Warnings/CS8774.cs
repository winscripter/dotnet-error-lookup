namespace dotnet_error_lookup.Data.Errors;

public class CS8774 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8774";
    string IErrorOrWarning.Message => @"Member '{0}' must have a non-null value when exiting.";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' must have a non-null value when exiting.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
