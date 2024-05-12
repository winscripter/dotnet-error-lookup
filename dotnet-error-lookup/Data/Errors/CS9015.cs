namespace dotnet_error_lookup.Data.Errors;

public class CS9015 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9015";
    string IErrorOrWarning.Message => @"Use of possibly unassigned field '{0}'. Consider updating to language version '{1}' to auto-default the field.";
    string IErrorOrWarning.Explanation => @"[original] Use of possibly unassigned field '{0}'. Consider updating to language version '{1}' to auto-default the field.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
