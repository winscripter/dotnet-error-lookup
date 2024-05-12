namespace dotnet_error_lookup.Data.Errors;

public class CS0278 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0278";
    string IErrorOrWarning.Message => @"'{0}' does not implement the '{1}' pattern. '{2}' is ambiguous with '{3}'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement the '{1}' pattern. '{2}' is ambiguous with '{3}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0278";
}
