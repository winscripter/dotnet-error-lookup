namespace dotnet_error_lookup.Data.Errors;

public class CS2011 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2011";
    string IErrorOrWarning.Message => @"Error opening response file '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Error opening response file '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2011";
}
