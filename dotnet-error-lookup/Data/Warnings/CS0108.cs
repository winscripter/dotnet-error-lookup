namespace dotnet_error_lookup.Data.Errors;

public class CS0108 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0108";
    string IErrorOrWarning.Message => @"'{0}' hides inherited member '{1}'. Use the new keyword if hiding was intended.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' hides inherited member '{1}'. Use the new keyword if hiding was intended.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0108";
}
