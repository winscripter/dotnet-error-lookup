namespace dotnet_error_lookup.Data.Errors;

public class CS8179 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8179";
    string IErrorOrWarning.Message => @"Predefined type '{0}' is not defined or imported";
    string IErrorOrWarning.Explanation => @"[original] Predefined type '{0}' is not defined or imported";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
