namespace dotnet_error_lookup.Data.Errors;

public class CS8337 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8337";
    string IErrorOrWarning.Message => @"The first parameter of a 'ref' extension method '{0}' must be a value type or a generic type constrained to struct.";
    string IErrorOrWarning.Explanation => @"[original] The first parameter of a 'ref' extension method '{0}' must be a value type or a generic type constrained to struct.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
