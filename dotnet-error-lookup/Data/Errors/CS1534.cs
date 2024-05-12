namespace dotnet_error_lookup.Data.Errors;

public class CS1534 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1534";
    string IErrorOrWarning.Message => @"Overloaded binary operator '{0}' takes two parameters";
    string IErrorOrWarning.Explanation => @"[original] Overloaded binary operator '{0}' takes two parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1534";
}
