namespace dotnet_error_lookup.Data.Errors;

public class CS8870 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8870";
    string IErrorOrWarning.Message => @"'{0}' cannot be sealed because containing record is not sealed.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be sealed because containing record is not sealed.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
