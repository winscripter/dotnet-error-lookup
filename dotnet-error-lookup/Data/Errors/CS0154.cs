namespace dotnet_error_lookup.Data.Errors;

public class CS0154 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0154";
    string IErrorOrWarning.Message => @"The property or indexer '{0}' cannot be used in this context because it lacks the get accessor";
    string IErrorOrWarning.Explanation => @"[original] The property or indexer '{0}' cannot be used in this context because it lacks the get accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0154";
}
