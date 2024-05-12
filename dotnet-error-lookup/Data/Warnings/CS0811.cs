namespace dotnet_error_lookup.Data.Errors;

public class CS0811 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0811";
    string IErrorOrWarning.Message => @"The fully qualified name for '{0}' is too long for debug information. Compile without '/debug' option.";
    string IErrorOrWarning.Explanation => @"[original] The fully qualified name for '{0}' is too long for debug information. Compile without '/debug' option.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0811";
}
