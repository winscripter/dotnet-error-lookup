namespace dotnet_error_lookup.Data.Errors;

public class CS0630 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0630";
    string IErrorOrWarning.Message => @"'{0}' cannot implement interface member '{1}' in type '{2}' because it has an \_\_arglist parameter";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot implement interface member '{1}' in type '{2}' because it has an \_\_arglist parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
