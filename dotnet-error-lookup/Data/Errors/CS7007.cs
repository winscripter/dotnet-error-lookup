namespace dotnet_error_lookup.Data.Errors;

public class CS7007 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7007";
    string IErrorOrWarning.Message => @"A 'using static' directive can only be applied to types; '{0}' is a namespace not a type. Consider a 'using namespace' directive instead";
    string IErrorOrWarning.Explanation => @"[original] A 'using static' directive can only be applied to types; '{0}' is a namespace not a type. Consider a 'using namespace' directive instead";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
