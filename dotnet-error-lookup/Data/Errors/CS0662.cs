namespace dotnet_error_lookup.Data.Errors;

public class CS0662 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0662";
    string IErrorOrWarning.Message => @"Cannot specify the Out attribute on a ref parameter without also specifying the In attribute.";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify the Out attribute on a ref parameter without also specifying the In attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0662";
}
