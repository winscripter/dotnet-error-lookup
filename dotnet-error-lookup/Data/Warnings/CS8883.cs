namespace dotnet_error_lookup.Data.Errors;

public class CS8883 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8883";
    string IErrorOrWarning.Message => @"Use of possibly unassigned auto-implemented property '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Use of possibly unassigned auto-implemented property '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
