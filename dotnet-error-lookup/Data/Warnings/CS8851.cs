namespace dotnet_error_lookup.Data.Errors;

public class CS8851 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8851";
    string IErrorOrWarning.Message => @"'{0}' defines 'Equals' but not 'GetHashCode'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' defines 'Equals' but not 'GetHashCode'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
