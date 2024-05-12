namespace dotnet_error_lookup.Data.Errors;

public class CS0407 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0407";
    string IErrorOrWarning.Message => @"'{1} {0}' has the wrong return type";
    string IErrorOrWarning.Explanation => @"[original] '{1} {0}' has the wrong return type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0407";
}
