namespace dotnet_error_lookup.Data.Errors;

public class CS9048 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9048";
    string IErrorOrWarning.Message => @"The 'scoped' modifier can be used for refs and ref struct values only.";
    string IErrorOrWarning.Explanation => @"[original] The 'scoped' modifier can be used for refs and ref struct values only.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
