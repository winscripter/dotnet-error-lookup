namespace dotnet_error_lookup.Data.Errors;

public class CS1922 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1922";
    string IErrorOrWarning.Message => @"Cannot initialize type '{0}' with a collection initializer because it does not implement 'System.Collections.IEnumerable'";
    string IErrorOrWarning.Explanation => @"[original] Cannot initialize type '{0}' with a collection initializer because it does not implement 'System.Collections.IEnumerable'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1922";
}
