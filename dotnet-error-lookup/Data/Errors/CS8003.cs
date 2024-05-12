namespace dotnet_error_lookup.Data.Errors;

public class CS8003 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8003";
    string IErrorOrWarning.Message => @"Invalid signature public key specified in AssemblySignatureKeyAttribute.";
    string IErrorOrWarning.Explanation => @"[original] Invalid signature public key specified in AssemblySignatureKeyAttribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
