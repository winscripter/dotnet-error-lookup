namespace dotnet_error_lookup.Data.Errors;

public class CS1672 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1672";
    string IErrorOrWarning.Message => @"Invalid option '{0}' for /platform; must be anycpu, x86, Itanium, arm, arm64 or x64";
    string IErrorOrWarning.Explanation => @"[original] Invalid option '{0}' for /platform; must be anycpu, x86, Itanium, arm, arm64 or x64";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1672";
}
