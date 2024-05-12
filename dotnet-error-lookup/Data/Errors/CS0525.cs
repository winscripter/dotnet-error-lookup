namespace dotnet_error_lookup.Data.Errors;

public class CS0525 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0525";
    string IErrorOrWarning.Message => @"Interfaces cannot contain instance fields";
    string IErrorOrWarning.Explanation => @"[original] Interfaces cannot contain instance fields";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0525";
}
