namespace dotnet_error_lookup.Data.Errors;

public class CS0708 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0708";
    string IErrorOrWarning.Message => @"'{0}': cannot declare instance members in a static class";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot declare instance members in a static class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0708";
}
