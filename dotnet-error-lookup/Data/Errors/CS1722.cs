namespace dotnet_error_lookup.Data.Errors;

public class CS1722 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1722";
    string IErrorOrWarning.Message => @"Base class '{0}' must come before any interfaces";
    string IErrorOrWarning.Explanation => @"[original] Base class '{0}' must come before any interfaces";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1722";
}
