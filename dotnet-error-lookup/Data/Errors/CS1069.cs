namespace dotnet_error_lookup.Data.Errors;

public class CS1069 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1069";
    string IErrorOrWarning.Message => @"The type name '{0}' could not be found in the namespace '{1}'. This type has been forwarded to assembly '{2}' Consider adding a reference to that assembly.";
    string IErrorOrWarning.Explanation => @"[original] The type name '{0}' could not be found in the namespace '{1}'. This type has been forwarded to assembly '{2}' Consider adding a reference to that assembly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
