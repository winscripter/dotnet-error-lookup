namespace dotnet_error_lookup.Data.Errors;

public class CS0041 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Fatal;
    string IErrorOrWarning.Name => @"CS0041";
    string IErrorOrWarning.Message => @"Unexpected error writing debug information -- '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Unexpected error writing debug information -- '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0041";
}
