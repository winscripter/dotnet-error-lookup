namespace dotnet_error_lookup.Data.Errors;

public class CS8136 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8136";
    string IErrorOrWarning.Message => @"Deconstruction 'var (...)' form disallows a specific type for 'var'.";
    string IErrorOrWarning.Explanation => @"[original] Deconstruction 'var (...)' form disallows a specific type for 'var'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
