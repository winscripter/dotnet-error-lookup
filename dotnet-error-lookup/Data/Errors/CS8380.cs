namespace dotnet_error_lookup.Data.Errors;

public class CS8380 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8380";
    string IErrorOrWarning.Message => @"'{0}': cannot specify both a constraint class and the 'unmanaged' constraint";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot specify both a constraint class and the 'unmanaged' constraint";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
