namespace dotnet_error_lookup.Data.Errors;

public class CS1515 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1515";
    string IErrorOrWarning.Message => @"'in' expected";
    string IErrorOrWarning.Explanation => @"[original] 'in' expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1515";
}
