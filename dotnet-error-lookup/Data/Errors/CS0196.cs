namespace dotnet_error_lookup.Data.Errors;

public class CS0196 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0196";
    string IErrorOrWarning.Message => @"A pointer must be indexed by only one value";
    string IErrorOrWarning.Explanation => @"[original] A pointer must be indexed by only one value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0196";
}
