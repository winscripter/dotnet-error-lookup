namespace dotnet_error_lookup.Data.Errors;

public class CS2001 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2001";
    string IErrorOrWarning.Message => @"Source file '{0}' could not be found.";
    string IErrorOrWarning.Explanation => @"[original] Source file '{0}' could not be found.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2001";
}
