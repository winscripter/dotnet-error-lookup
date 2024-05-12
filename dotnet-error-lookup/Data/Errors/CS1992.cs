namespace dotnet_error_lookup.Data.Errors;

public class CS1992 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1992";
    string IErrorOrWarning.Message => @"The 'await' operator can only be used when contained within a method or lambda expression marked with the 'async' modifier";
    string IErrorOrWarning.Explanation => @"[original] The 'await' operator can only be used when contained within a method or lambda expression marked with the 'async' modifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
