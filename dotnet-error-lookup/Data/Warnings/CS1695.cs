namespace dotnet_error_lookup.Data.Errors;

public class CS1695 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1695";
    string IErrorOrWarning.Message => @"Invalid #pragma checksum syntax; should be #pragma checksum ""filename"" ""{XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX}"" ""XXXX...""";
    string IErrorOrWarning.Explanation => @"[original] Invalid #pragma checksum syntax; should be #pragma checksum ""filename"" ""{XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX}"" ""XXXX...""";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1695";
}
