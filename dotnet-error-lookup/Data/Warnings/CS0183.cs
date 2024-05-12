namespace dotnet_error_lookup.Data.Errors;

public class CS0183 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0183";
    string IErrorOrWarning.Message => @"The given expression is always of the provided ('{0}') type";
    string IErrorOrWarning.Explanation => @"[original] The given expression is always of the provided ('{0}') type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0183";
}
