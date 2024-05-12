namespace dotnet_error_lookup.Data.Errors;

public class CS1966 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1966";
    string IErrorOrWarning.Message => @"'{0}': cannot implement a dynamic interface '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot implement a dynamic interface '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
