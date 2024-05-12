namespace dotnet_error_lookup.Data.Errors;

public class CS8356 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8356";
    string IErrorOrWarning.Message => @"Predefined type '{0}' is declared in multiple referenced assemblies: '{1}' and '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Predefined type '{0}' is declared in multiple referenced assemblies: '{1}' and '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
