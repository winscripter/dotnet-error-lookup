namespace dotnet_error_lookup.Data.Errors;

public class CS2002 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS2002";
    string IErrorOrWarning.Message => @"Source file '{0}' specified multiple times";
    string IErrorOrWarning.Explanation => @"[original] Source file '{0}' specified multiple times";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2002";
}
