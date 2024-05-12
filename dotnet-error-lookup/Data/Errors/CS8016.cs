namespace dotnet_error_lookup.Data.Errors;

public class CS8016 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8016";
    string IErrorOrWarning.Message => @"Transparent identifier member access failed for field '{0}' of '{1}'.  Does the data being queried implement the query pattern?";
    string IErrorOrWarning.Explanation => @"[original] Transparent identifier member access failed for field '{0}' of '{1}'.  Does the data being queried implement the query pattern?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
