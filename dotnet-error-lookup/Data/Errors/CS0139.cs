namespace dotnet_error_lookup.Data.Errors;

public class CS0139 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0139";
    string IErrorOrWarning.Message => @"No enclosing loop out of which to break or continue";
    string IErrorOrWarning.Explanation => @"[original] No enclosing loop out of which to break or continue";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0139";
}
