namespace dotnet_error_lookup.Data.Errors;

public class CS9084 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9084";
    string IErrorOrWarning.Message => @"Struct member returns 'this' or other instance members by reference";
    string IErrorOrWarning.Explanation => @"[original] Struct member returns 'this' or other instance members by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
