namespace dotnet_error_lookup.Data.Errors;

public class CS9010 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9010";
    string IErrorOrWarning.Message => @"Keyword 'enum' cannot be used as a constraint. Did you mean 'struct, System.Enum'?";
    string IErrorOrWarning.Explanation => @"[original] Keyword 'enum' cannot be used as a constraint. Did you mean 'struct, System.Enum'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
