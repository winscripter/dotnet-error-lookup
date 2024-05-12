namespace dotnet_error_lookup.Data.Errors;

public class CS9014 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9014";
    string IErrorOrWarning.Message => @"Use of possibly unassigned auto-implemented property '{0}'. Consider updating to language version '{1}' to auto-default the property.";
    string IErrorOrWarning.Explanation => @"[original] Use of possibly unassigned auto-implemented property '{0}'. Consider updating to language version '{1}' to auto-default the property.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
