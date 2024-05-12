namespace dotnet_error_lookup.Data.Errors;

public class CS9042 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9042";
    string IErrorOrWarning.Message => @"Required member '{0}' should not be attributed with 'ObsoleteAttribute' unless the containing type is obsolete or all constructors are obsolete.";
    string IErrorOrWarning.Explanation => @"[original] Required member '{0}' should not be attributed with 'ObsoleteAttribute' unless the containing type is obsolete or all constructors are obsolete.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
