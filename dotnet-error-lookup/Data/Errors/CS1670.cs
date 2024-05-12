namespace dotnet_error_lookup.Data.Errors;

public class CS1670 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1670";
    string IErrorOrWarning.Message => @"params is not valid in this context";
    string IErrorOrWarning.Explanation => @"[original] params is not valid in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1670";
}
