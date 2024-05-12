namespace dotnet_error_lookup.Data.Errors;

public class CS9030 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9030";
    string IErrorOrWarning.Message => @"'{0}' must be required because it overrides required member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' must be required because it overrides required member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
