namespace dotnet_error_lookup.Data.Errors;

public class CS1633 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1633";
    string IErrorOrWarning.Message => @"Unrecognized #pragma directive";
    string IErrorOrWarning.Explanation => @"[original] Unrecognized #pragma directive";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1633";
}
