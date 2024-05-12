namespace dotnet_error_lookup.Data.Errors;

public class CS8343 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8343";
    string IErrorOrWarning.Message => @"'{0}': ref structs cannot implement interfaces";
    string IErrorOrWarning.Explanation => @"[original] '{0}': ref structs cannot implement interfaces";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
