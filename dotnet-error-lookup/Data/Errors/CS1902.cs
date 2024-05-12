namespace dotnet_error_lookup.Data.Errors;

public class CS1902 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1902";
    string IErrorOrWarning.Message => @"Invalid option '{0}' for /debug; must be 'portable', 'embedded', 'full' or 'pdbonly'";
    string IErrorOrWarning.Explanation => @"[original] Invalid option '{0}' for /debug; must be 'portable', 'embedded', 'full' or 'pdbonly'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1902";
}
