namespace dotnet_error_lookup.Data.Errors;

public class CS8649 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8649";
    string IErrorOrWarning.Message => @"A goto cannot jump to a location before a using declaration within the same block.";
    string IErrorOrWarning.Explanation => @"[original] A goto cannot jump to a location before a using declaration within the same block.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
