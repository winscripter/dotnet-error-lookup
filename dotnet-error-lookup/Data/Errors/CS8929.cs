namespace dotnet_error_lookup.Data.Errors;

public class CS8929 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8929";
    string IErrorOrWarning.Message => @"'{0}' cannot implement interface member '{1}' in type '{2}' because the target runtime doesn't support static abstract members in interfaces.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot implement interface member '{1}' in type '{2}' because the target runtime doesn't support static abstract members in interfaces.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
