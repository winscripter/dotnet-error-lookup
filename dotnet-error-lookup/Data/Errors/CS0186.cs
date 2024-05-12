namespace dotnet_error_lookup.Data.Errors;

public class CS0186 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0186";
    string IErrorOrWarning.Message => @"Use of null is not valid in this context";
    string IErrorOrWarning.Explanation => @"[original] Use of null is not valid in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0186";
}
