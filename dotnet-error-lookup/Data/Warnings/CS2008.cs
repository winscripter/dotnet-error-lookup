namespace dotnet_error_lookup.Data.Errors;

public class CS2008 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS2008";
    string IErrorOrWarning.Message => @"No source files specified.";
    string IErrorOrWarning.Explanation => @"[original] No source files specified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2008";
}
