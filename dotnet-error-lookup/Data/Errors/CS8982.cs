namespace dotnet_error_lookup.Data.Errors;

public class CS8982 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8982";
    string IErrorOrWarning.Message => @"A constructor declared in a 'struct' with parameter list must have a 'this' initializer that calls the primary constructor or an explicitly declared constructor.";
    string IErrorOrWarning.Explanation => @"[original] A constructor declared in a 'struct' with parameter list must have a 'this' initializer that calls the primary constructor or an explicitly declared constructor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
