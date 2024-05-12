namespace dotnet_error_lookup.Data.Errors;

public class CS8374 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8374";
    string IErrorOrWarning.Message => @"Cannot ref-assign '{1}' to '{0}' because '{1}' has a narrower escape scope than '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot ref-assign '{1}' to '{0}' because '{1}' has a narrower escape scope than '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8374";
}
