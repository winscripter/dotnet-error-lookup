namespace dotnet_error_lookup.Data.Errors;

public class CS1971 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1971";
    string IErrorOrWarning.Message => @"The call to method '{0}' needs to be dynamically dispatched, but cannot be because it is part of a base access expression. Consider casting the dynamic arguments or eliminating the base access.";
    string IErrorOrWarning.Explanation => @"[original] The call to method '{0}' needs to be dynamically dispatched, but cannot be because it is part of a base access expression. Consider casting the dynamic arguments or eliminating the base access.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
