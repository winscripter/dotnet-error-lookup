namespace dotnet_error_lookup.Data.Errors;

public class CS1068 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1068";
    string IErrorOrWarning.Message => @"The type name '{0}' could not be found in the global namespace. This type has been forwarded to assembly '{1}' Consider adding a reference to that assembly.";
    string IErrorOrWarning.Explanation => @"[original] The type name '{0}' could not be found in the global namespace. This type has been forwarded to assembly '{1}' Consider adding a reference to that assembly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
