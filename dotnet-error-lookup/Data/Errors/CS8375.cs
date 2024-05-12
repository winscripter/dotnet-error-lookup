namespace dotnet_error_lookup.Data.Errors;

public class CS8375 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8375";
    string IErrorOrWarning.Message => @"The 'new()' constraint cannot be used with the 'unmanaged' constraint";
    string IErrorOrWarning.Explanation => @"[original] The 'new()' constraint cannot be used with the 'unmanaged' constraint";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
