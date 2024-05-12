namespace dotnet_error_lookup.Data.Errors;

public class CS2019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Fatal;
    string IErrorOrWarning.Name => @"CS2019";
    string IErrorOrWarning.Message => @"Invalid target type for /target: must specify 'exe', 'winexe', 'library', or 'module'";
    string IErrorOrWarning.Explanation => @"[original] Invalid target type for /target: must specify 'exe', 'winexe', 'library', or 'module'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2019";
}
