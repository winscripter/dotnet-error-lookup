namespace dotnet_error_lookup.Data.Errors;

public class CS0036 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0036";
    string IErrorOrWarning.Message => @"An out parameter cannot have the In attribute";
    string IErrorOrWarning.Explanation => @"[original] An out parameter cannot have the In attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0036";
}
