namespace dotnet_error_lookup.Data.Errors;

public class CS7103 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7103";
    string IErrorOrWarning.Message => @"Unable to read debug information of method '{0}' (token 0x{1:X8}) from assembly '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Unable to read debug information of method '{0}' (token 0x{1:X8}) from assembly '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
