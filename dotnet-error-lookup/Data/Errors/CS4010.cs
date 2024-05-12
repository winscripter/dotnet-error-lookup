namespace dotnet_error_lookup.Data.Errors;

public class CS4010 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4010";
    string IErrorOrWarning.Message => @"Cannot convert async {0} to delegate type '{1}'. An async {0} may return void, Task or Task\<T\>, none of which are convertible to '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert async {0} to delegate type '{1}'. An async {0} may return void, Task or Task\<T\>, none of which are convertible to '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
