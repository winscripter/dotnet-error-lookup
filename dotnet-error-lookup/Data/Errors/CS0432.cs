namespace dotnet_error_lookup.Data.Errors;

public class CS0432 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0432";
    string IErrorOrWarning.Message => @"Alias '{0}' not found";
    string IErrorOrWarning.Explanation => @"[original] Alias '{0}' not found";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0432";
}
