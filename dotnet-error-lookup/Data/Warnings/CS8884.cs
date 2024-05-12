namespace dotnet_error_lookup.Data.Errors;

public class CS8884 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8884";
    string IErrorOrWarning.Message => @"Use of possibly unassigned field '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Use of possibly unassigned field '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
