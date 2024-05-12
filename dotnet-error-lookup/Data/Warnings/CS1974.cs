namespace dotnet_error_lookup.Data.Errors;

public class CS1974 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1974";
    string IErrorOrWarning.Message => @"The dynamically dispatched call to method '{0}' may fail at runtime because one or more applicable overloads are conditional methods.";
    string IErrorOrWarning.Explanation => @"[original] The dynamically dispatched call to method '{0}' may fail at runtime because one or more applicable overloads are conditional methods.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
