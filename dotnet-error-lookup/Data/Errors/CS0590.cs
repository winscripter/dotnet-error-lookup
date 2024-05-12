namespace dotnet_error_lookup.Data.Errors;

public class CS0590 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0590";
    string IErrorOrWarning.Message => @"User-defined operators cannot return void";
    string IErrorOrWarning.Explanation => @"[original] User-defined operators cannot return void";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0590";
}
