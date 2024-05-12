namespace dotnet_error_lookup.Data.Errors;

public class CS1995 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1995";
    string IErrorOrWarning.Message => @"The 'await' operator may only be used in a query expression within the first collection expression of the initial 'from' clause or within the collection expression of a 'join' clause";
    string IErrorOrWarning.Explanation => @"[original] The 'await' operator may only be used in a query expression within the first collection expression of the initial 'from' clause or within the collection expression of a 'join' clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
