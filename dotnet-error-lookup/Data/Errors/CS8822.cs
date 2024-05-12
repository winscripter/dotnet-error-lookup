namespace dotnet_error_lookup.Data.Errors;

public class CS8822 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8822";
    string IErrorOrWarning.Message => @"Method '{0}' specifies a 'default' constraint for type parameter '{1}', but corresponding type parameter '{2}' of overridden or explicitly implemented method '{3}' is constrained to a reference type or a value type.";
    string IErrorOrWarning.Explanation => @"[original] Method '{0}' specifies a 'default' constraint for type parameter '{1}', but corresponding type parameter '{2}' of overridden or explicitly implemented method '{3}' is constrained to a reference type or a value type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
