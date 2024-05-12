namespace dotnet_error_lookup.Data.Errors;

public class CS1521 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1521";
    string IErrorOrWarning.Message => @"Invalid base type";
    string IErrorOrWarning.Explanation => @"[original] Invalid base type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1521";
}
