namespace dotnet_error_lookup.Data.Errors;

public class CS8328 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8328";
    string IErrorOrWarning.Message => @" The parameter modifier '{0}' cannot be used with '{1}'";
    string IErrorOrWarning.Explanation => @"[original]  The parameter modifier '{0}' cannot be used with '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
