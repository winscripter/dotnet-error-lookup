namespace dotnet_error_lookup.Data.Errors;

public class CS1991 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1991";
    string IErrorOrWarning.Message => @"'{0}' cannot implement '{1}' because '{2}' is a Windows Runtime event and '{3}' is a regular .NET event.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot implement '{1}' because '{2}' is a Windows Runtime event and '{3}' is a regular .NET event.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
