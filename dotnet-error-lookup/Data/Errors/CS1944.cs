namespace dotnet_error_lookup.Data.Errors;

public class CS1944 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1944";
    string IErrorOrWarning.Message => @"An expression tree may not contain an unsafe pointer operation";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain an unsafe pointer operation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1944";
}
