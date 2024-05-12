namespace dotnet_error_lookup.Data.Errors;

public class CS9130 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9130";
    string IErrorOrWarning.Message => @"Using alias cannot be a 'ref' type.";
    string IErrorOrWarning.Explanation => @"[original] Using alias cannot be a 'ref' type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
