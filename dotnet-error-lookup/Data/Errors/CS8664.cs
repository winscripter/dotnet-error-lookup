namespace dotnet_error_lookup.Data.Errors;

public class CS8664 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8664";
    string IErrorOrWarning.Message => @"'{0}': 'readonly' can only be used on accessors if the property or indexer has both a get and a set accessor";
    string IErrorOrWarning.Explanation => @"[original] '{0}': 'readonly' can only be used on accessors if the property or indexer has both a get and a set accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
