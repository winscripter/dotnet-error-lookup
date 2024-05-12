namespace dotnet_error_lookup.Data.Errors;

public class CS1937 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1937";
    string IErrorOrWarning.Message => @"The name '{0}' is not in scope on the left side of 'equals'.  Consider swapping the expressions on either side of 'equals'.";
    string IErrorOrWarning.Explanation => @"[original] The name '{0}' is not in scope on the left side of 'equals'.  Consider swapping the expressions on either side of 'equals'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1937";
}
