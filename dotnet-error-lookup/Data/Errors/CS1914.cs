namespace dotnet_error_lookup.Data.Errors;

public class CS1914 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1914";
    string IErrorOrWarning.Message => @"Static field or property '{0}' cannot be assigned in an object initializer";
    string IErrorOrWarning.Explanation => @"[original] Static field or property '{0}' cannot be assigned in an object initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1914";
}
