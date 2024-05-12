namespace dotnet_error_lookup.Data.Errors;

public class CS0564 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0564";
    string IErrorOrWarning.Message => @"The first operand of an overloaded shift operator must have the same type as the containing type";
    string IErrorOrWarning.Explanation => @"[original] The first operand of an overloaded shift operator must have the same type as the containing type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0564";
}
