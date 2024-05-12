namespace dotnet_error_lookup.Data.Errors;

public class CS8702 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8702";
    string IErrorOrWarning.Message => @"'{0}' cannot implement interface member '{1}' in type '{2}' because the target runtime doesn't support default interface implementation.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot implement interface member '{1}' in type '{2}' because the target runtime doesn't support default interface implementation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
