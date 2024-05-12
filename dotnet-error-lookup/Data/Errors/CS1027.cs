namespace dotnet_error_lookup.Data.Errors;

public class CS1027 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1027";
    string IErrorOrWarning.Message => @"#endif directive expected";
    string IErrorOrWarning.Explanation => @"[original] #endif directive expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1027";
}
