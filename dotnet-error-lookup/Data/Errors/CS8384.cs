namespace dotnet_error_lookup.Data.Errors;

public class CS8384 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8384";
    string IErrorOrWarning.Message => @"Tuple types used as operands of an == or != operator must have matching cardinalities. But this operator has tuple types of cardinality {0} on the left and {1} on the right.";
    string IErrorOrWarning.Explanation => @"[original] Tuple types used as operands of an == or != operator must have matching cardinalities. But this operator has tuple types of cardinality {0} on the left and {1} on the right.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
