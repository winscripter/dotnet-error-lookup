namespace dotnet_error_lookup.Data.Errors;

public class CS1016 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1016";
    string IErrorOrWarning.Message => @"Named attribute argument expected";
    string IErrorOrWarning.Explanation => @"[original] Named attribute argument expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1016";
}
