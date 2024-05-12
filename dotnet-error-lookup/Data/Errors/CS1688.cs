namespace dotnet_error_lookup.Data.Errors;

public class CS1688 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1688";
    string IErrorOrWarning.Message => @"Cannot convert anonymous method block without a parameter list to delegate type '{0}' because it has one or more out parameters";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert anonymous method block without a parameter list to delegate type '{0}' because it has one or more out parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1688";
}
