namespace dotnet_error_lookup.Data.Errors;

public class CS0720 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0720";
    string IErrorOrWarning.Message => @"'{0}': cannot declare indexers in a static class";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot declare indexers in a static class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0720";
}
