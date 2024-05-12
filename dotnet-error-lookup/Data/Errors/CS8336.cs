namespace dotnet_error_lookup.Data.Errors;

public class CS8336 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8336";
    string IErrorOrWarning.Message => @"The type name '{0}' is reserved to be used by the compiler.";
    string IErrorOrWarning.Explanation => @"[original] The type name '{0}' is reserved to be used by the compiler.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
