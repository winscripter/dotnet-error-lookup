namespace dotnet_error_lookup.Data.Errors;

public class CS9039 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9039";
    string IErrorOrWarning.Message => @"This constructor must add 'SetsRequiredMembers' because it chains to a constructor that has that attribute.";
    string IErrorOrWarning.Explanation => @"[original] This constructor must add 'SetsRequiredMembers' because it chains to a constructor that has that attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
