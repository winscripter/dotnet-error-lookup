namespace dotnet_error_lookup.Data.Errors;

public class CS8306 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8306";
    string IErrorOrWarning.Message => @"Tuple element name '{0}' is inferred. Please use language version {1} or greater to access an element by its inferred name.";
    string IErrorOrWarning.Explanation => @"[original] Tuple element name '{0}' is inferred. Please use language version {1} or greater to access an element by its inferred name.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
