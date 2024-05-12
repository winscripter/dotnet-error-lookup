namespace dotnet_error_lookup.Data.Errors;

public class CS2015 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2015";
    string IErrorOrWarning.Message => @"'{0}' is a binary file instead of a text file";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is a binary file instead of a text file";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2015";
}
