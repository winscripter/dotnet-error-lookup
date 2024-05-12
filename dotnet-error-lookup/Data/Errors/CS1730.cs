namespace dotnet_error_lookup.Data.Errors;

public class CS1730 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1730";
    string IErrorOrWarning.Message => @"Assembly and module attributes must precede all other elements defined in a file except using clauses and extern alias declarations";
    string IErrorOrWarning.Explanation => @"[original] Assembly and module attributes must precede all other elements defined in a file except using clauses and extern alias declarations";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1730";
}
