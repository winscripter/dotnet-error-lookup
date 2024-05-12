namespace dotnet_error_lookup.Data.Errors;

public class CS8079 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8079";
    string IErrorOrWarning.Message => @"Use of possibly unassigned auto-implemented property '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Use of possibly unassigned auto-implemented property '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
