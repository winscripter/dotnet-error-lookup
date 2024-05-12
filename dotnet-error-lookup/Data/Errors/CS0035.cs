namespace dotnet_error_lookup.Data.Errors;

public class CS0035 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0035";
    string IErrorOrWarning.Message => @"Operator '{0}' is ambiguous on an operand of type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' is ambiguous on an operand of type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0035";
}
