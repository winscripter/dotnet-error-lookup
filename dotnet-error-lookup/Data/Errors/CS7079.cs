namespace dotnet_error_lookup.Data.Errors;

public class CS7079 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7079";
    string IErrorOrWarning.Message => @"The type '{0}' is defined in a module that has not been added. You must add the module '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' is defined in a module that has not been added. You must add the module '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
