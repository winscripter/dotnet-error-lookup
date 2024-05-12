namespace dotnet_error_lookup.Data.Errors;

public class CS1972 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1972";
    string IErrorOrWarning.Message => @"The indexer access needs to be dynamically dispatched, but cannot be because it is part of a base access expression. Consider casting the dynamic arguments or eliminating the base access.";
    string IErrorOrWarning.Explanation => @"[original] The indexer access needs to be dynamically dispatched, but cannot be because it is part of a base access expression. Consider casting the dynamic arguments or eliminating the base access.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
