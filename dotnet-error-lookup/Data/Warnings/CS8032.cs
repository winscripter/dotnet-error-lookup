namespace dotnet_error_lookup.Data.Errors;

public class CS8032 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8032";
    string IErrorOrWarning.Message => @"An instance of analyzer {0} cannot be created from {1} : {2}.";
    string IErrorOrWarning.Explanation => @"[original] An instance of analyzer {0} cannot be created from {1} : {2}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
