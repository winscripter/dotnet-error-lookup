namespace dotnet_error_lookup.Data.Errors;

public class CS1589 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1589";
    string IErrorOrWarning.Message => @"Unable to include XML fragment '{1}' of file '{0}' -- {2}";
    string IErrorOrWarning.Explanation => @"[original] Unable to include XML fragment '{1}' of file '{0}' -- {2}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1589";
}
