namespace dotnet_error_lookup.Data.Errors;

public class CS9044 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9044";
    string IErrorOrWarning.Message => @"'{0}' does not implement interface member '{1}'. '{2}' cannot implicitly implement an inaccessible member.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement interface member '{1}'. '{2}' cannot implicitly implement an inaccessible member.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
