namespace dotnet_error_lookup.Data.Errors;

public class CS1562 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1562";
    string IErrorOrWarning.Message => @"Outputs without source must have the /out option specified";
    string IErrorOrWarning.Explanation => @"[original] Outputs without source must have the /out option specified";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1562";
}
