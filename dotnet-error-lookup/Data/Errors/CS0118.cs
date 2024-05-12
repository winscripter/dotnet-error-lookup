namespace dotnet_error_lookup.Data.Errors;

public class CS0118 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0118";
    string IErrorOrWarning.Message => @"'{0}' is a {1} but is used like a {2}";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is a {1} but is used like a {2}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0118";
}
