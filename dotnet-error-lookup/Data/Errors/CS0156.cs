namespace dotnet_error_lookup.Data.Errors;

public class CS0156 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0156";
    string IErrorOrWarning.Message => @"A throw statement with no arguments is not allowed outside of a catch clause";
    string IErrorOrWarning.Explanation => @"[original] A throw statement with no arguments is not allowed outside of a catch clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0156";
}
