namespace dotnet_error_lookup.Data.Errors;

public class CS1719 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1719";
    string IErrorOrWarning.Message => @"Error opening Win32 resource file '{0}' -- '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Error opening Win32 resource file '{0}' -- '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1719";
}
