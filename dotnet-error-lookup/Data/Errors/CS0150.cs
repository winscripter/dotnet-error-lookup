namespace dotnet_error_lookup.Data.Errors;

public class CS0150 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0150";
    string IErrorOrWarning.Message => @"A constant value is expected";
    string IErrorOrWarning.Explanation => @"[original] A constant value is expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0150";
}
