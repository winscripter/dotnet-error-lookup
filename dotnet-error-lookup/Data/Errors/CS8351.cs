namespace dotnet_error_lookup.Data.Errors;

public class CS8351 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8351";
    string IErrorOrWarning.Message => @"Branches of a ref conditional operator cannot refer to variables with incompatible declaration scopes";
    string IErrorOrWarning.Explanation => @"[original] Branches of a ref conditional operator cannot refer to variables with incompatible declaration scopes";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
