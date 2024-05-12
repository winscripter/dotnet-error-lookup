namespace dotnet_error_lookup.Data.Errors;

public class CS1592 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1592";
    string IErrorOrWarning.Message => @"Badly formed XML in included comments file -- '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Badly formed XML in included comments file -- '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1592";
}
