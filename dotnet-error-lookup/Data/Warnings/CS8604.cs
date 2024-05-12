namespace dotnet_error_lookup.Data.Errors;

public class CS8604 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8604";
    string IErrorOrWarning.Message => @"Possible null reference argument for parameter '{0}' in '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Possible null reference argument for parameter '{0}' in '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
