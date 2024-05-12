namespace dotnet_error_lookup.Data.Errors;

public class CS0280 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0280";
    string IErrorOrWarning.Message => @"'{0}' does not implement the '{1}' pattern. '{2}' has the wrong signature.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement the '{1}' pattern. '{2}' has the wrong signature.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0280";
}
