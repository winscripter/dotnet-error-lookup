namespace dotnet_error_lookup.Data.Errors;

public class CS8413 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8413";
    string IErrorOrWarning.Message => @"Asynchronous foreach statement cannot operate on variables of type '{0}' because it implements multiple instantiations of '{1}'; try casting to a specific interface instantiation";
    string IErrorOrWarning.Explanation => @"[original] Asynchronous foreach statement cannot operate on variables of type '{0}' because it implements multiple instantiations of '{1}'; try casting to a specific interface instantiation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
