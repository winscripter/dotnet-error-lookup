namespace dotnet_error_lookup.Data.Errors;

public class CS8522 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8522";
    string IErrorOrWarning.Message => @"Element names are not permitted when pattern-matching via 'System.Runtime.CompilerServices.ITuple'.";
    string IErrorOrWarning.Explanation => @"[original] Element names are not permitted when pattern-matching via 'System.Runtime.CompilerServices.ITuple'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
