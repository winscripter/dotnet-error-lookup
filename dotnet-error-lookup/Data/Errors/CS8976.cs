namespace dotnet_error_lookup.Data.Errors;

public class CS8976 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8976";
    string IErrorOrWarning.Message => @"Interpolated string handler conversions that reference the instance being indexed cannot be used in indexer member initializers.";
    string IErrorOrWarning.Explanation => @"[original] Interpolated string handler conversions that reference the instance being indexed cannot be used in indexer member initializers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
