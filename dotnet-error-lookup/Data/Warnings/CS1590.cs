namespace dotnet_error_lookup.Data.Errors;

public class CS1590 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1590";
    string IErrorOrWarning.Message => @"Invalid XML include element -- {0}";
    string IErrorOrWarning.Explanation => @"[original] Invalid XML include element -- {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1590";
}
