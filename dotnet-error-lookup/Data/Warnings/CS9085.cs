namespace dotnet_error_lookup.Data.Errors;

public class CS9085 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9085";
    string IErrorOrWarning.Message => @"This ref-assigns '{1}' to '{0}' but '{1}' has a narrower escape scope than '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] This ref-assigns '{1}' to '{0}' but '{1}' has a narrower escape scope than '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
