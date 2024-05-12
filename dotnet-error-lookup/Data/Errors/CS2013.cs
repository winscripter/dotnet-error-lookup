namespace dotnet_error_lookup.Data.Errors;

public class CS2013 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2013";
    string IErrorOrWarning.Message => @"Invalid image base number '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Invalid image base number '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2013";
}
