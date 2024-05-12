namespace dotnet_error_lookup.Data.Errors;

public class CS1965 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1965";
    string IErrorOrWarning.Message => @"'{0}': cannot derive from the dynamic type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot derive from the dynamic type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
