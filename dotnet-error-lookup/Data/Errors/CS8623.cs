namespace dotnet_error_lookup.Data.Errors;

public class CS8623 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8623";
    string IErrorOrWarning.Message => @"Explicit application of 'System.Runtime.CompilerServices.NullableAttribute' is not allowed.";
    string IErrorOrWarning.Explanation => @"[original] Explicit application of 'System.Runtime.CompilerServices.NullableAttribute' is not allowed.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
