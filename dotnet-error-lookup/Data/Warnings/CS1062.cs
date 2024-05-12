namespace dotnet_error_lookup.Data.Errors;

public class CS1062 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1062";
    string IErrorOrWarning.Message => @"The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}";
    string IErrorOrWarning.Explanation => @"[original] The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
