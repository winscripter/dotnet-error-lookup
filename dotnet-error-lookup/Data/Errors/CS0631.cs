namespace dotnet_error_lookup.Data.Errors;

public class CS0631 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0631";
    string IErrorOrWarning.Message => @"ref and out are not valid in this context";
    string IErrorOrWarning.Explanation => @"[original] ref and out are not valid in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0631";
}
