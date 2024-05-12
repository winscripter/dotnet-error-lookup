namespace dotnet_error_lookup.Data.Errors;

public class CS0837 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0837";
    string IErrorOrWarning.Message => @"The first operand of an 'is' or 'as' operator may not be a lambda expression, anonymous method, or method group.";
    string IErrorOrWarning.Explanation => @"[original] The first operand of an 'is' or 'as' operator may not be a lambda expression, anonymous method, or method group.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0837";
}
