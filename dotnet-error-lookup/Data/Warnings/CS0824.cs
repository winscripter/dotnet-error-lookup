namespace dotnet_error_lookup.Data.Errors;

public class CS0824 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0824";
    string IErrorOrWarning.Message => @"Constructor '{0}' is marked external";
    string IErrorOrWarning.Explanation => @"[original] Constructor '{0}' is marked external";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0824";
}
