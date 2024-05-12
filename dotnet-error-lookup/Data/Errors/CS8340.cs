namespace dotnet_error_lookup.Data.Errors;

public class CS8340 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8340";
    string IErrorOrWarning.Message => @"Instance fields of readonly structs must be readonly.";
    string IErrorOrWarning.Explanation => @"[original] Instance fields of readonly structs must be readonly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
