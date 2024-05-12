namespace dotnet_error_lookup.Data.Errors;

public class CS8752 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8752";
    string IErrorOrWarning.Message => @"The type '{0}' may not be used as the target type of new()";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' may not be used as the target type of new()";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
