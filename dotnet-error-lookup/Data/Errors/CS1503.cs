namespace dotnet_error_lookup.Data.Errors;

public class CS1503 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1503";
    string IErrorOrWarning.Message => @"Argument {0}: cannot convert from '{1}' to '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Argument {0}: cannot convert from '{1}' to '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1503";
}
