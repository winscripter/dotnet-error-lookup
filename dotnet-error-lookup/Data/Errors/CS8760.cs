namespace dotnet_error_lookup.Data.Errors;

public class CS8760 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8760";
    string IErrorOrWarning.Message => @"'{0}': extern event cannot have initializer";
    string IErrorOrWarning.Explanation => @"[original] '{0}': extern event cannot have initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
