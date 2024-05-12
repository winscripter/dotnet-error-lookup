namespace dotnet_error_lookup.Data.Errors;

public class CS1031 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1031";
    string IErrorOrWarning.Message => @"Type expected";
    string IErrorOrWarning.Explanation => @"[original] Type expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1031";
}
