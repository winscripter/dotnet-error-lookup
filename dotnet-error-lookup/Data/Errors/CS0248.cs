namespace dotnet_error_lookup.Data.Errors;

public class CS0248 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0248";
    string IErrorOrWarning.Message => @"Cannot create an array with a negative size";
    string IErrorOrWarning.Explanation => @"[original] Cannot create an array with a negative size";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0248";
}
