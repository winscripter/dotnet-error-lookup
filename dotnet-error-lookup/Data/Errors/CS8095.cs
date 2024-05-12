namespace dotnet_error_lookup.Data.Errors;

public class CS8095 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8095";
    string IErrorOrWarning.Message => @"Length of String constant resulting from concatenation exceeds System.Int32.MaxValue.  Try splitting the string into multiple constants.";
    string IErrorOrWarning.Explanation => @"[original] Length of String constant resulting from concatenation exceeds System.Int32.MaxValue.  Try splitting the string into multiple constants.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
