namespace dotnet_error_lookup.Data.Errors;

public class CS0601 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0601";
    string IErrorOrWarning.Message => @"The DllImport attribute must be specified on a method marked 'static' and 'extern'";
    string IErrorOrWarning.Explanation => @"[original] The DllImport attribute must be specified on a method marked 'static' and 'extern'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0601";
}
