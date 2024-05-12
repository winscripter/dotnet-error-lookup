namespace dotnet_error_lookup.Data.Errors;

public class CS0591 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0591";
    string IErrorOrWarning.Message => @"Invalid value for argument to '{0}' attribute";
    string IErrorOrWarning.Explanation => @"[original] Invalid value for argument to '{0}' attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0591";
}
