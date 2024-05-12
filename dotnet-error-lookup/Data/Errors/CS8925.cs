namespace dotnet_error_lookup.Data.Errors;

public class CS8925 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8925";
    string IErrorOrWarning.Message => @"The first operand of an overloaded shift operator must have the same type as the containing type or its type parameter constrained to it";
    string IErrorOrWarning.Explanation => @"[original] The first operand of an overloaded shift operator must have the same type as the containing type or its type parameter constrained to it";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
