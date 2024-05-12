namespace dotnet_error_lookup.Data.Errors;

public class CS1718 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1718";
    string IErrorOrWarning.Message => @"Comparison made to same variable; did you mean to compare something else?";
    string IErrorOrWarning.Explanation => @"[original] Comparison made to same variable; did you mean to compare something else?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1718";
}
