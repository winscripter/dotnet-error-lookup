namespace dotnet_error_lookup.Data.Errors;

public class CS8940 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8940";
    string IErrorOrWarning.Message => @"A generic task-like return type was expected, but the type '{0}' found in 'AsyncMethodBuilder' attribute was not suitable. It must be an unbound generic type of arity one, and its containing type (if any) must be non-generic.";
    string IErrorOrWarning.Explanation => @"[original] A generic task-like return type was expected, but the type '{0}' found in 'AsyncMethodBuilder' attribute was not suitable. It must be an unbound generic type of arity one, and its containing type (if any) must be non-generic.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
