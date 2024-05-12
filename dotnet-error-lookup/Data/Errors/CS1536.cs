namespace dotnet_error_lookup.Data.Errors;

public class CS1536 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1536";
    string IErrorOrWarning.Message => @"Invalid parameter type 'void'";
    string IErrorOrWarning.Explanation => @"[original] Invalid parameter type 'void'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1536";
}
