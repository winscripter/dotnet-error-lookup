namespace dotnet_error_lookup.Data.Errors;

public class CS0735 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0735";
    string IErrorOrWarning.Message => @"Invalid type specified as an argument for TypeForwardedTo attribute";
    string IErrorOrWarning.Explanation => @"[original] Invalid type specified as an argument for TypeForwardedTo attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0735";
}
