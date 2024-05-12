namespace dotnet_error_lookup.Data.Errors;

public class CS0109 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0109";
    string IErrorOrWarning.Message => @"The member '{0}' does not hide an accessible member. The new keyword is not required.";
    string IErrorOrWarning.Explanation => @"[original] The member '{0}' does not hide an accessible member. The new keyword is not required.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0109";
}
