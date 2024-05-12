namespace dotnet_error_lookup.Data.Errors;

public class CS1064 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1064";
    string IErrorOrWarning.Message => @"The best overloaded Add method '{0}' for the collection initializer element is obsolete.";
    string IErrorOrWarning.Explanation => @"[original] The best overloaded Add method '{0}' for the collection initializer element is obsolete.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
