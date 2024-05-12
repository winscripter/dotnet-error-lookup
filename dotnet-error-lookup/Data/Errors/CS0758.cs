namespace dotnet_error_lookup.Data.Errors;

public class CS0758 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0758";
    string IErrorOrWarning.Message => @"Both partial method declarations must use a params parameter or neither may use a params parameter";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must use a params parameter or neither may use a params parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0758";
}
