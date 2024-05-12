namespace dotnet_error_lookup.Data.Errors;

public class CS9060 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9060";
    string IErrorOrWarning.Message => @"Cannot use a numeric constant or relational pattern on '{0}' because it inherits from or extends 'INumberBase\<T\>'. Consider using a type pattern to narrow to a specifc numeric type.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use a numeric constant or relational pattern on '{0}' because it inherits from or extends 'INumberBase\<T\>'. Consider using a type pattern to narrow to a specifc numeric type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
