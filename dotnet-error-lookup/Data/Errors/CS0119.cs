namespace dotnet_error_lookup.Data.Errors;

public class CS0119 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0119";
    string IErrorOrWarning.Message => @"'{0}' is a {1}, which is not valid in the given context";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is a {1}, which is not valid in the given context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0119";
}
