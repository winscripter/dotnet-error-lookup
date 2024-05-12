namespace dotnet_error_lookup.Data.Errors;

public class CS1597 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1597";
    string IErrorOrWarning.Message => @"Semicolon after method or accessor block is not valid";
    string IErrorOrWarning.Explanation => @"[original] Semicolon after method or accessor block is not valid";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1597";
}
