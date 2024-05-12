namespace dotnet_error_lookup.Data.Errors;

public class CS0262 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0262";
    string IErrorOrWarning.Message => @"Partial declarations of '{0}' have conflicting accessibility modifiers";
    string IErrorOrWarning.Explanation => @"[original] Partial declarations of '{0}' have conflicting accessibility modifiers";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0262";
}
