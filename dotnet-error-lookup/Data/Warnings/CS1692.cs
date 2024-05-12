namespace dotnet_error_lookup.Data.Errors;

public class CS1692 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1692";
    string IErrorOrWarning.Message => @"Invalid number";
    string IErrorOrWarning.Explanation => @"[original] Invalid number";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1692";
}
