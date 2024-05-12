namespace dotnet_error_lookup.Data.Errors;

public class CS0839 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0839";
    string IErrorOrWarning.Message => @"Argument missing";
    string IErrorOrWarning.Explanation => @"[original] Argument missing";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0839";
}
