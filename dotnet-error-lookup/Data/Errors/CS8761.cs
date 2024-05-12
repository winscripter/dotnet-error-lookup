namespace dotnet_error_lookup.Data.Errors;

public class CS8761 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8761";
    string IErrorOrWarning.Message => @"Operator '{0}' cannot be applied to 'default' and operand of type '{1}' because it is a type parameter that is not known to be a reference type";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' cannot be applied to 'default' and operand of type '{1}' because it is a type parameter that is not known to be a reference type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
