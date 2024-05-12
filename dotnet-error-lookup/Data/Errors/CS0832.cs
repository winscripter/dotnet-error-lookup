namespace dotnet_error_lookup.Data.Errors;

public class CS0832 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0832";
    string IErrorOrWarning.Message => @"An expression tree may not contain an assignment operator";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain an assignment operator";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0832";
}
