namespace dotnet_error_lookup.Data.Errors;

public class CS0053 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0053";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: property type '{1}' is less accessible than property '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: property type '{1}' is less accessible than property '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0053";
}
