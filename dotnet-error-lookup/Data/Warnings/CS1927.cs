namespace dotnet_error_lookup.Data.Errors;

public class CS1927 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1927";
    string IErrorOrWarning.Message => @"Ignoring /win32manifest for module because it only applies to assemblies";
    string IErrorOrWarning.Explanation => @"[original] Ignoring /win32manifest for module because it only applies to assemblies";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1927";
}
