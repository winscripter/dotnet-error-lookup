namespace dotnet_error_lookup.Data.Errors;

public class CS9086 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9086";
    string IErrorOrWarning.Message => @"The branches of the ref conditional operator refer to variables with incompatible declaration scopes";
    string IErrorOrWarning.Explanation => @"[original] The branches of the ref conditional operator refer to variables with incompatible declaration scopes";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
