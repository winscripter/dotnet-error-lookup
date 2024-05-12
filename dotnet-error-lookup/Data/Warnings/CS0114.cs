namespace dotnet_error_lookup.Data.Errors;

public class CS0114 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0114";
    string IErrorOrWarning.Message => @"'{0}' hides inherited member '{1}'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' hides inherited member '{1}'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0114";
}
