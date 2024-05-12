namespace dotnet_error_lookup.Data.Errors;

public class CS0754 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0754";
    string IErrorOrWarning.Message => @"A partial method may not explicitly implement an interface method";
    string IErrorOrWarning.Explanation => @"[original] A partial method may not explicitly implement an interface method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0754";
}
