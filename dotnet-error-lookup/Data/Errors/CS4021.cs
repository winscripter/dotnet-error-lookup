namespace dotnet_error_lookup.Data.Errors;

public class CS4021 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4021";
    string IErrorOrWarning.Message => @"The CallerFilePathAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.Explanation => @"[original] The CallerFilePathAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
