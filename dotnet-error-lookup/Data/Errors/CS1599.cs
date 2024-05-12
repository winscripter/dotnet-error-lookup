namespace dotnet_error_lookup.Data.Errors;

public class CS1599 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1599";
    string IErrorOrWarning.Message => @"The return type of a method, delegate, or function pointer cannot be '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The return type of a method, delegate, or function pointer cannot be '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1599";
}
