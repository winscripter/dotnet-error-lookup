namespace dotnet_error_lookup.Data.Errors;

public class CS0155 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0155";
    string IErrorOrWarning.Message => @"The type caught or thrown must be derived from System.Exception";
    string IErrorOrWarning.Explanation => @"[original] The type caught or thrown must be derived from System.Exception";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0155";
}
