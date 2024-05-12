namespace dotnet_error_lookup.Data.Errors;

public class CS8823 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8823";
    string IErrorOrWarning.Message => @"The 'default' constraint is valid on override and explicit interface implementation methods only.";
    string IErrorOrWarning.Explanation => @"[original] The 'default' constraint is valid on override and explicit interface implementation methods only.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
