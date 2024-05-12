namespace dotnet_error_lookup.Data.Errors;

public class CS8779 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8779";
    string IErrorOrWarning.Message => @"'{0}' is already listed in the interface list on type '{2}' as '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is already listed in the interface list on type '{2}' as '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
