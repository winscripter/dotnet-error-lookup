namespace dotnet_error_lookup.Data.Errors;

public class CS3024 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3024";
    string IErrorOrWarning.Message => @"Constraint type '{0}' is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Constraint type '{0}' is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3024";
}
