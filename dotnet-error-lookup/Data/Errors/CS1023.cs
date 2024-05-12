namespace dotnet_error_lookup.Data.Errors;

public class CS1023 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1023";
    string IErrorOrWarning.Message => @"Embedded statement cannot be a declaration or labeled statement";
    string IErrorOrWarning.Explanation => @"[original] Embedded statement cannot be a declaration or labeled statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1023";
}
