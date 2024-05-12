namespace dotnet_error_lookup.Data.Errors;

public class CS9132 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9132";
    string IErrorOrWarning.Message => @"Using alias cannot be a nullable reference type.";
    string IErrorOrWarning.Explanation => @"[original] Using alias cannot be a nullable reference type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
