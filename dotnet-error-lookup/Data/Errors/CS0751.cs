namespace dotnet_error_lookup.Data.Errors;

public class CS0751 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0751";
    string IErrorOrWarning.Message => @"A partial method must be declared within a partial type";
    string IErrorOrWarning.Explanation => @"[original] A partial method must be declared within a partial type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0751";
}
