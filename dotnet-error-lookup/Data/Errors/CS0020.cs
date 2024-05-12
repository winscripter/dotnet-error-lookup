namespace dotnet_error_lookup.Data.Errors;

public class CS0020 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0020";
    string IErrorOrWarning.Message => @"Division by constant zero";
    string IErrorOrWarning.Explanation => @"[original] Division by constant zero";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0020";
}
