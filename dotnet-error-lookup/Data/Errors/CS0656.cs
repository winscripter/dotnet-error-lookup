namespace dotnet_error_lookup.Data.Errors;

public class CS0656 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0656";
    string IErrorOrWarning.Message => @"Missing compiler required member '{0}.{1}'";
    string IErrorOrWarning.Explanation => @"[original] Missing compiler required member '{0}.{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0656";
}
