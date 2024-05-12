namespace dotnet_error_lookup.Data.Errors;

public class CS8103 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8103";
    string IErrorOrWarning.Message => @"Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals.";
    string IErrorOrWarning.Explanation => @"[original] Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
