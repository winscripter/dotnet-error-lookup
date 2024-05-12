namespace dotnet_error_lookup.Data.Errors;

public class CS7070 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7070";
    string IErrorOrWarning.Message => @"Security attribute '{0}' is not valid on this declaration type. Security attributes are only valid on assembly, type and method declarations.";
    string IErrorOrWarning.Explanation => @"[original] Security attribute '{0}' is not valid on this declaration type. Security attributes are only valid on assembly, type and method declarations.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
