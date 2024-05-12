namespace dotnet_error_lookup.Data.Errors;

public class CS8775 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8775";
    string IErrorOrWarning.Message => @"Member '{0}' must have a non-null value when exiting with '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' must have a non-null value when exiting with '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
