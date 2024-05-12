namespace dotnet_error_lookup.Data.Errors;

public class CS8750 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8750";
    string IErrorOrWarning.Message => @"Type '{0}' cannot be embedded because it has a re-abstraction of a member from base interface. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' cannot be embedded because it has a re-abstraction of a member from base interface. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
