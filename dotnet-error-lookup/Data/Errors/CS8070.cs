namespace dotnet_error_lookup.Data.Errors;

public class CS8070 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8070";
    string IErrorOrWarning.Message => @"Control cannot fall out of switch from final case label ('{0}')";
    string IErrorOrWarning.Explanation => @"[original] Control cannot fall out of switch from final case label ('{0}')";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
