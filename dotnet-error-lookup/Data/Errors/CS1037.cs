namespace dotnet_error_lookup.Data.Errors;

public class CS1037 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1037";
    string IErrorOrWarning.Message => @"Overloadable operator expected";
    string IErrorOrWarning.Explanation => @"[original] Overloadable operator expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1037";
}
