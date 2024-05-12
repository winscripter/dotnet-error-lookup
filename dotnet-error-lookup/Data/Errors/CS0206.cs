namespace dotnet_error_lookup.Data.Errors;

public class CS0206 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0206";
    string IErrorOrWarning.Message => @"A non ref-returning property or indexer may not be used as an out or ref value";
    string IErrorOrWarning.Explanation => @"[original] A non ref-returning property or indexer may not be used as an out or ref value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0206";
}
