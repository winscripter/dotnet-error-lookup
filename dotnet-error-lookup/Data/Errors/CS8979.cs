namespace dotnet_error_lookup.Data.Errors;

public class CS8979 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8979";
    string IErrorOrWarning.Message => @"List patterns may not be used for a value of type '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] List patterns may not be used for a value of type '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
