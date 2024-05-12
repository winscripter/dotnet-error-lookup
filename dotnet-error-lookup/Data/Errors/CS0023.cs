namespace dotnet_error_lookup.Data.Errors;

public class CS0023 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0023";
    string IErrorOrWarning.Message => @"Operator '{0}' cannot be applied to operand of type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' cannot be applied to operand of type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0023";
}
