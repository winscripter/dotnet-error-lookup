namespace dotnet_error_lookup.Data.Errors;

public class CS4011 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4011";
    string IErrorOrWarning.Message => @"'await' requires that the return type '{0}' of '{1}.GetAwaiter()' have suitable 'IsCompleted', 'OnCompleted', and 'GetResult' members, and implement 'INotifyCompletion' or 'ICriticalNotifyCompletion'";
    string IErrorOrWarning.Explanation => @"[original] 'await' requires that the return type '{0}' of '{1}.GetAwaiter()' have suitable 'IsCompleted', 'OnCompleted', and 'GetResult' members, and implement 'INotifyCompletion' or 'ICriticalNotifyCompletion'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
