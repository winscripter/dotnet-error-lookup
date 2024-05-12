namespace dotnet_error_lookup.Data.Errors;

public class CS8013 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8013";
    string IErrorOrWarning.Message => @"Cryptographic failure while creating hashes.";
    string IErrorOrWarning.Explanation => @"[original] Cryptographic failure while creating hashes.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
