namespace dotnet_error_lookup.Data.Errors;

public class CS0205 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0205";
    string IErrorOrWarning.Message => @"Cannot call an abstract base member: '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot call an abstract base member: '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0205";
}
