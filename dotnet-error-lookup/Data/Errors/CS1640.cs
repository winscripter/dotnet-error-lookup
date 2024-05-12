namespace dotnet_error_lookup.Data.Errors;

public class CS1640 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1640";
    string IErrorOrWarning.Message => @"foreach statement cannot operate on variables of type '{0}' because it implements multiple instantiations of '{1}'; try casting to a specific interface instantiation";
    string IErrorOrWarning.Explanation => @"[original] foreach statement cannot operate on variables of type '{0}' because it implements multiple instantiations of '{1}'; try casting to a specific interface instantiation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1640";
}
