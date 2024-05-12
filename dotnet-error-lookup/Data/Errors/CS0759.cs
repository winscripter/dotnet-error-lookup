namespace dotnet_error_lookup.Data.Errors;

public class CS0759 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0759";
    string IErrorOrWarning.Message => @"No defining declaration found for implementing declaration of partial method '{0}'";
    string IErrorOrWarning.Explanation => @"[original] No defining declaration found for implementing declaration of partial method '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0759";
}
