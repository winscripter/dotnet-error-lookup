namespace dotnet_error_lookup.Data.Errors;

public class CS1931 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1931";
    string IErrorOrWarning.Message => @"The range variable '{0}' conflicts with a previous declaration of '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The range variable '{0}' conflicts with a previous declaration of '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1931";
}
