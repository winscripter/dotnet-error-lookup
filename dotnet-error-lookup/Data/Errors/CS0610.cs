namespace dotnet_error_lookup.Data.Errors;

public class CS0610 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0610";
    string IErrorOrWarning.Message => @"Field or property cannot be of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Field or property cannot be of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0610";
}
