namespace dotnet_error_lookup.Data.Errors;

public class CS9089 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9089";
    string IErrorOrWarning.Message => @"This returns by reference a member of parameter '{0}' that is not a ref or out parameter";
    string IErrorOrWarning.Explanation => @"[original] This returns by reference a member of parameter '{0}' that is not a ref or out parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
