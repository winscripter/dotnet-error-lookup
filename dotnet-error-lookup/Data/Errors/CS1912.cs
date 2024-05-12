namespace dotnet_error_lookup.Data.Errors;

public class CS1912 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1912";
    string IErrorOrWarning.Message => @"Duplicate initialization of member '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Duplicate initialization of member '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1912";
}
