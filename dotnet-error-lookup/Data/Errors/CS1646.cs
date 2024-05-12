namespace dotnet_error_lookup.Data.Errors;

public class CS1646 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1646";
    string IErrorOrWarning.Message => @"Keyword, identifier, or string expected after verbatim specifier: @";
    string IErrorOrWarning.Explanation => @"[original] Keyword, identifier, or string expected after verbatim specifier: @";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1646";
}
