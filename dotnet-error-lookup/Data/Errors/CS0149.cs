namespace dotnet_error_lookup.Data.Errors;

public class CS0149 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0149";
    string IErrorOrWarning.Message => @"Method name expected";
    string IErrorOrWarning.Explanation => @"[original] Method name expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0149";
}
