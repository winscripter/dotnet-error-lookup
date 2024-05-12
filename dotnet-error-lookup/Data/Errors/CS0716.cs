namespace dotnet_error_lookup.Data.Errors;

public class CS0716 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0716";
    string IErrorOrWarning.Message => @"Cannot convert to static type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert to static type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0716";
}
