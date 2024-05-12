namespace dotnet_error_lookup.Data.Errors;

public class CS0649 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0649";
    string IErrorOrWarning.Message => @"Field '{0}' is never assigned to, and will always have its default value {1}";
    string IErrorOrWarning.Explanation => @"[original] Field '{0}' is never assigned to, and will always have its default value {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0649";
}
