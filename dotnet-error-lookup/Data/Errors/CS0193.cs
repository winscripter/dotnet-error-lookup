namespace dotnet_error_lookup.Data.Errors;

public class CS0193 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0193";
    string IErrorOrWarning.Message => @"The * or -\> operator must be applied to a pointer";
    string IErrorOrWarning.Explanation => @"[original] The \* or -\> operator must be applied to a pointer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0193";
}
