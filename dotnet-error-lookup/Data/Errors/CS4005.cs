namespace dotnet_error_lookup.Data.Errors;

public class CS4005 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4005";
    string IErrorOrWarning.Message => @"Async methods cannot have unsafe parameters or return types";
    string IErrorOrWarning.Explanation => @"[original] Async methods cannot have unsafe parameters or return types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
