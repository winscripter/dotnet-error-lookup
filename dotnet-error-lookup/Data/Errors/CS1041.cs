namespace dotnet_error_lookup.Data.Errors;

public class CS1041 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1041";
    string IErrorOrWarning.Message => @"Identifier expected; '{1}' is a keyword";
    string IErrorOrWarning.Explanation => @"[original] Identifier expected; '{1}' is a keyword";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1041";
}
