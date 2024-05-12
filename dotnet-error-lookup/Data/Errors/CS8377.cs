namespace dotnet_error_lookup.Data.Errors;

public class CS8377 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8377";
    string IErrorOrWarning.Message => @"The type '{2}' must be a non-nullable value type, along with all fields at any level of nesting, in order to use it as parameter '{1}' in the generic type or method '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The type '{2}' must be a non-nullable value type, along with all fields at any level of nesting, in order to use it as parameter '{1}' in the generic type or method '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
