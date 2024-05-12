namespace dotnet_error_lookup.Data.Errors;

public class CS1770 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1770";
    string IErrorOrWarning.Message => @"A value of type '{0}' cannot be used as default parameter for nullable parameter '{1}' because '{0}' is not a simple type";
    string IErrorOrWarning.Explanation => @"[original] A value of type '{0}' cannot be used as default parameter for nullable parameter '{1}' because '{0}' is not a simple type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
