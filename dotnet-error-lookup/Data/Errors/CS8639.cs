namespace dotnet_error_lookup.Data.Errors;

public class CS8639 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8639";
    string IErrorOrWarning.Message => @"The typeof operator cannot be used on a nullable reference type";
    string IErrorOrWarning.Explanation => @"[original] The typeof operator cannot be used on a nullable reference type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
