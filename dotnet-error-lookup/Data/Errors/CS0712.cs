namespace dotnet_error_lookup.Data.Errors;

public class CS0712 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0712";
    string IErrorOrWarning.Message => @"Cannot create an instance of the static class '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot create an instance of the static class '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0712";
}
