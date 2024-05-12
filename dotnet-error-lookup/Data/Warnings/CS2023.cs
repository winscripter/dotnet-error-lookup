namespace dotnet_error_lookup.Data.Errors;

public class CS2023 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS2023";
    string IErrorOrWarning.Message => @"Ignoring /noconfig option because it was specified in a response file";
    string IErrorOrWarning.Explanation => @"[original] Ignoring /noconfig option because it was specified in a response file";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2023";
}
