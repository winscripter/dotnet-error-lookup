namespace dotnet_error_lookup.Data.Errors;

public class CS0463 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0463";
    string IErrorOrWarning.Message => @"Evaluation of the decimal constant expression failed";
    string IErrorOrWarning.Explanation => @"[original] Evaluation of the decimal constant expression failed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0463";
}
