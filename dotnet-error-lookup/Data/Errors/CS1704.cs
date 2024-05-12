namespace dotnet_error_lookup.Data.Errors;

public class CS1704 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1704";
    string IErrorOrWarning.Message => @"An assembly with the same simple name '{0}' has already been imported. Try removing one of the references (e.g. '{1}') or sign them to enable side-by-side.";
    string IErrorOrWarning.Explanation => @"[original] An assembly with the same simple name '{0}' has already been imported. Try removing one of the references (e.g. '{1}') or sign them to enable side-by-side.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1704";
}
