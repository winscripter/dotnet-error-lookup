namespace dotnet_error_lookup.Data.Errors;

public class CS1697 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1697";
    string IErrorOrWarning.Message => @"Different checksum values given for '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Different checksum values given for '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1697";
}
