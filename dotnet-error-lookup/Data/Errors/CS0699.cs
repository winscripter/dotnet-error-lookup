namespace dotnet_error_lookup.Data.Errors;

public class CS0699 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0699";
    string IErrorOrWarning.Message => @"'{1}' does not define type parameter '{0}'";
    string IErrorOrWarning.Explanation => @"[original] '{1}' does not define type parameter '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0699";
}
