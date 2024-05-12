namespace dotnet_error_lookup.Data.Errors;

public class CS8204 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8204";
    string IErrorOrWarning.Message => @"For type '{0}' to be used as an AsyncMethodBuilder for type '{1}', its Task property should return type '{1}' instead of type '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] For type '{0}' to be used as an AsyncMethodBuilder for type '{1}', its Task property should return type '{1}' instead of type '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
