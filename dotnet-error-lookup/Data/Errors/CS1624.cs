namespace dotnet_error_lookup.Data.Errors;

public class CS1624 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1624";
    string IErrorOrWarning.Message => @"The body of '{0}' cannot be an iterator block because '{1}' is not an iterator interface type";
    string IErrorOrWarning.Explanation => @"[original] The body of '{0}' cannot be an iterator block because '{1}' is not an iterator interface type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1624";
}
