namespace dotnet_error_lookup.Data.Errors;

public class CS0457 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0457";
    string IErrorOrWarning.Message => @"Ambiguous user defined conversions '{0}' and '{1}' when converting from '{2}' to '{3}'";
    string IErrorOrWarning.Explanation => @"[original] Ambiguous user defined conversions '{0}' and '{1}' when converting from '{2}' to '{3}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0457";
}
