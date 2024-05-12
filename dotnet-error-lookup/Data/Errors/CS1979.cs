namespace dotnet_error_lookup.Data.Errors;

public class CS1979 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1979";
    string IErrorOrWarning.Message => @"Query expressions over source type 'dynamic' or with a join sequence of type 'dynamic' are not allowed";
    string IErrorOrWarning.Explanation => @"[original] Query expressions over source type 'dynamic' or with a join sequence of type 'dynamic' are not allowed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
