namespace dotnet_error_lookup.Data.Errors;

public class CS8943 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8943";
    string IErrorOrWarning.Message => @"null is not a valid parameter name. To get access to the receiver of an instance method, use the empty string as the parameter name.";
    string IErrorOrWarning.Explanation => @"[original] null is not a valid parameter name. To get access to the receiver of an instance method, use the empty string as the parameter name.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
