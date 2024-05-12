namespace dotnet_error_lookup.Data.Errors;

public class CS8808 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8808";
    string IErrorOrWarning.Message => @"'{0}' is not a valid function pointer return type modifier. Valid modifiers are 'ref' and 'ref readonly'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a valid function pointer return type modifier. Valid modifiers are 'ref' and 'ref readonly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
