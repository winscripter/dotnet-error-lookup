namespace dotnet_error_lookup.Data.Errors;

public class CS0279 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0279";
    string IErrorOrWarning.Message => @"'{0}' does not implement the '{1}' pattern. '{2}' is not a public instance or extension method.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement the '{1}' pattern. '{2}' is not a public instance or extension method.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0279";
}
