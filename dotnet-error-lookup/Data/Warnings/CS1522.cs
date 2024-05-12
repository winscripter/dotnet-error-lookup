namespace dotnet_error_lookup.Data.Errors;

public class CS1522 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1522";
    string IErrorOrWarning.Message => @"Empty switch block";
    string IErrorOrWarning.Explanation => @"[original] Empty switch block";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1522";
}
