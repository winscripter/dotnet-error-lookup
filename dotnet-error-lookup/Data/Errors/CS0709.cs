namespace dotnet_error_lookup.Data.Errors;

public class CS0709 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0709";
    string IErrorOrWarning.Message => @"'{1}': cannot derive from static class '{0}'";
    string IErrorOrWarning.Explanation => @"[original] '{1}': cannot derive from static class '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0709";
}
