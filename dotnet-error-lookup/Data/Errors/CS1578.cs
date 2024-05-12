namespace dotnet_error_lookup.Data.Errors;

public class CS1578 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1578";
    string IErrorOrWarning.Message => @"Quoted file name, single-line comment or end-of-line expected";
    string IErrorOrWarning.Explanation => @"[original] Quoted file name, single-line comment or end-of-line expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1578";
}
