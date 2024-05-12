namespace dotnet_error_lookup.Data.Errors;

public class CS8636 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8636";
    string IErrorOrWarning.Message => @"Invalid option '{0}' for /nullable; must be 'disable', 'enable', 'warnings' or 'annotations'";
    string IErrorOrWarning.Explanation => @"[original] Invalid option '{0}' for /nullable; must be 'disable', 'enable', 'warnings' or 'annotations'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
