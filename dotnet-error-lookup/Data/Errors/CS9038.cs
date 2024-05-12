namespace dotnet_error_lookup.Data.Errors;

public class CS9038 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9038";
    string IErrorOrWarning.Message => @"The required members list for the base type '{0}' is malformed and cannot be interpreted. To use this constructor, apply the 'SetsRequiredMembers' attribute.";
    string IErrorOrWarning.Explanation => @"[original] The required members list for the base type '{0}' is malformed and cannot be interpreted. To use this constructor, apply the 'SetsRequiredMembers' attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
