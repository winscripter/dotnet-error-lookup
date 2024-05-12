namespace dotnet_error_lookup.Data.Errors;

public class CS8338 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8338";
    string IErrorOrWarning.Message => @"The first parameter of the 'in' extension method '{0}' must be a concrete (non-generic) value type.";
    string IErrorOrWarning.Explanation => @"[original] The first parameter of the 'in' extension method '{0}' must be a concrete (non-generic) value type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
