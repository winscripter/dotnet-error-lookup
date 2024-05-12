namespace dotnet_error_lookup.Data.Errors;

public class CS8503 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8503";
    string IErrorOrWarning.Message => @"A property subpattern requires a reference to the property or field to be matched, e.g. '{{ Name: {0} }}'";
    string IErrorOrWarning.Explanation => @"[original] A property subpattern requires a reference to the property or field to be matched, e.g. '{{ Name: {0} }}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
