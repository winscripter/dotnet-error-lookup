namespace dotnet_error_lookup.Data.Errors;

public class CS1520 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1520";
    string IErrorOrWarning.Message => @"Method must have a return type";
    string IErrorOrWarning.Explanation => @"[original] Method must have a return type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1520";
}
