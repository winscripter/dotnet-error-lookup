namespace dotnet_error_lookup.Data.Errors;

public class CS8423 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8423";
    string IErrorOrWarning.Message => @"Attribute '{0}' is not valid on event accessors. It is only valid on '{1}' declarations.";
    string IErrorOrWarning.Explanation => @"[original] Attribute '{0}' is not valid on event accessors. It is only valid on '{1}' declarations.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
