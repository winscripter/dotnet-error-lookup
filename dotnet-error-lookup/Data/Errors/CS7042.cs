namespace dotnet_error_lookup.Data.Errors;

public class CS7042 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7042";
    string IErrorOrWarning.Message => @"The DllImport attribute cannot be applied to a method that is generic or contained in a generic method or type.";
    string IErrorOrWarning.Explanation => @"[original] The DllImport attribute cannot be applied to a method that is generic or contained in a generic method or type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
