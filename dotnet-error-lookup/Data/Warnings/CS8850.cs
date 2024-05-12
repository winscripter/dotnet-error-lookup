namespace dotnet_error_lookup.Data.Errors;

public class CS8850 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8850";
    string IErrorOrWarning.Message => @"The assembly '{0}' containing type '{1}' references .NET Framework, which is not supported.";
    string IErrorOrWarning.Explanation => @"[original] The assembly '{0}' containing type '{1}' references .NET Framework, which is not supported.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
