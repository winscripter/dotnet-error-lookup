namespace dotnet_error_lookup.Data.Errors;

public class CS8004 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8004";
    string IErrorOrWarning.Message => @"Type '{0}' exported from module '{1}' conflicts with type declared in primary module of this assembly.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' exported from module '{1}' conflicts with type declared in primary module of this assembly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
