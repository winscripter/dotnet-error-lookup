namespace dotnet_error_lookup.Data.Errors;

public class CS1524 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1524";
    string IErrorOrWarning.Message => @"Expected catch or finally";
    string IErrorOrWarning.Explanation => @"[original] Expected catch or finally";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1524";
}
