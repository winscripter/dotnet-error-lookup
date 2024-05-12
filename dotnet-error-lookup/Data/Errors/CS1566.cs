namespace dotnet_error_lookup.Data.Errors;

public class CS1566 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1566";
    string IErrorOrWarning.Message => @"Error reading resource '{0}' -- '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Error reading resource '{0}' -- '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1566";
}
