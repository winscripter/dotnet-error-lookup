namespace dotnet_error_lookup.Data.Errors;

public class CS1617 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1617";
    string IErrorOrWarning.Message => @"Invalid option '{0}' for /langversion. Use '/langversion:?' to list supported values.";
    string IErrorOrWarning.Explanation => @"[original] Invalid option '{0}' for /langversion. Use '/langversion:?' to list supported values.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1617";
}
