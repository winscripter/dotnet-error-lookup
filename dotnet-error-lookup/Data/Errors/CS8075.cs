namespace dotnet_error_lookup.Data.Errors;

public class CS8075 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8075";
    string IErrorOrWarning.Message => @"An extension Add method is not supported for a collection initializer in an expression lambda.";
    string IErrorOrWarning.Explanation => @"[original] An extension Add method is not supported for a collection initializer in an expression lambda.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
