namespace dotnet_error_lookup.Data.Errors;

public class CS7092 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7092";
    string IErrorOrWarning.Message => @"A fixed buffer may only have one dimension.";
    string IErrorOrWarning.Explanation => @"[original] A fixed buffer may only have one dimension.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
