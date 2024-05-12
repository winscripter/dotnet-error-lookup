namespace dotnet_error_lookup.Data.Errors;

public class CS0277 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0277";
    string IErrorOrWarning.Message => @"'{0}' does not implement interface member '{1}'. '{2}' is not public.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement interface member '{1}'. '{2}' is not public.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0277";
}
