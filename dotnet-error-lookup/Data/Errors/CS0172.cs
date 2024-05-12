namespace dotnet_error_lookup.Data.Errors;

public class CS0172 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0172";
    string IErrorOrWarning.Message => @"Type of conditional expression cannot be determined because '{0}' and '{1}' implicitly convert to one another";
    string IErrorOrWarning.Explanation => @"[original] Type of conditional expression cannot be determined because '{0}' and '{1}' implicitly convert to one another";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0172";
}
