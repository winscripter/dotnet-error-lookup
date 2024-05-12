namespace dotnet_error_lookup.Data.Errors;

public class CS0745 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0745";
    string IErrorOrWarning.Message => @"Expected contextual keyword 'by'";
    string IErrorOrWarning.Explanation => @"[original] Expected contextual keyword 'by'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0745";
}
