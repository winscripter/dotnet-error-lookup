namespace dotnet_error_lookup.Data.Errors;

public class CS0184 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0184";
    string IErrorOrWarning.Message => @"The given expression is never of the provided ('{0}') type";
    string IErrorOrWarning.Explanation => @"[original] The given expression is never of the provided ('{0}') type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0184";
}
