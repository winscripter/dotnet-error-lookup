namespace dotnet_error_lookup.Data.Errors;

public class CS4036 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4036";
    string IErrorOrWarning.Message => @"'{0}' does not contain a definition for '{1}' and no extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive for '{2}'?)";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not contain a definition for '{1}' and no extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive for '{2}'?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
