namespace dotnet_error_lookup.Data.Errors;

public class CS8817 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8817";
    string IErrorOrWarning.Message => @"Both partial method declarations must have the same return type.";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must have the same return type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
