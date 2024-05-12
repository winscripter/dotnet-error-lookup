namespace dotnet_error_lookup.Data.Errors;

public class CS1634 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1634";
    string IErrorOrWarning.Message => @"Expected 'disable' or 'restore'";
    string IErrorOrWarning.Explanation => @"[original] Expected 'disable' or 'restore'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1634";
}
