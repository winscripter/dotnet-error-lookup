namespace dotnet_error_lookup.Data.Errors;

public class CS1020 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1020";
    string IErrorOrWarning.Message => @"Overloadable binary operator expected";
    string IErrorOrWarning.Explanation => @"[original] Overloadable binary operator expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1020";
}
