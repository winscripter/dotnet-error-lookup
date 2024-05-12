namespace dotnet_error_lookup.Data.Errors;

public class CS0132 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0132";
    string IErrorOrWarning.Message => @"'{0}': a static constructor must be parameterless";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a static constructor must be parameterless";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0132";
}
