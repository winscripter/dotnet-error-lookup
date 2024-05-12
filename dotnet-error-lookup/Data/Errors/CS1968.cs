namespace dotnet_error_lookup.Data.Errors;

public class CS1968 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1968";
    string IErrorOrWarning.Message => @"Constraint cannot be a dynamic type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Constraint cannot be a dynamic type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
