namespace dotnet_error_lookup.Data.Errors;

public class CS9101 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9101";
    string IErrorOrWarning.Message => @"UnscopedRefAttribute can only be applied to struct instance methods and properties, and cannot be applied to constructors or init-only members.";
    string IErrorOrWarning.Explanation => @"[original] UnscopedRefAttribute can only be applied to struct instance methods and properties, and cannot be applied to constructors or init-only members.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
