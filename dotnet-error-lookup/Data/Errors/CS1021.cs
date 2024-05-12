namespace dotnet_error_lookup.Data.Errors;

public class CS1021 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1021";
    string IErrorOrWarning.Message => @"Integral constant is too large";
    string IErrorOrWarning.Explanation => @"[original] Integral constant is too large";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1021";
}
