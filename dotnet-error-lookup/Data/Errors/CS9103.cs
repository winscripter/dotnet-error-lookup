namespace dotnet_error_lookup.Data.Errors;

public class CS9103 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9103";
    string IErrorOrWarning.Message => @"'{0}' is defined in a module with an unrecognized RefSafetyRulesAttribute version, expecting '11'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is defined in a module with an unrecognized RefSafetyRulesAttribute version, expecting '11'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
