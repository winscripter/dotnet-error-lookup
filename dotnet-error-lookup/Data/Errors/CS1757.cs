namespace dotnet_error_lookup.Data.Errors;

public class CS1757 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1757";
    string IErrorOrWarning.Message => @"Embedded interop struct '{0}' can contain only public instance fields.";
    string IErrorOrWarning.Explanation => @"[original] Embedded interop struct '{0}' can contain only public instance fields.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
