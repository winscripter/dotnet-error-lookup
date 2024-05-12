namespace dotnet_error_lookup.Data.Errors;

public class CS4022 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4022";
    string IErrorOrWarning.Message => @"The CallerMemberNameAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.Explanation => @"[original] The CallerMemberNameAttribute may only be applied to parameters with default values";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
