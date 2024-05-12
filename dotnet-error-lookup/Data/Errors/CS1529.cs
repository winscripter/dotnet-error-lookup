namespace dotnet_error_lookup.Data.Errors;

public class CS1529 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1529";
    string IErrorOrWarning.Message => @"A using clause must precede all other elements defined in the namespace except extern alias declarations";
    string IErrorOrWarning.Explanation => @"[original] A using clause must precede all other elements defined in the namespace except extern alias declarations";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1529";
}
