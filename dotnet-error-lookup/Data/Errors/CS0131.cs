namespace dotnet_error_lookup.Data.Errors;

public class CS0131 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0131";
    string IErrorOrWarning.Message => @"The left-hand side of an assignment must be a variable, property or indexer";
    string IErrorOrWarning.Explanation => @"[original] The left-hand side of an assignment must be a variable, property or indexer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0131";
}
