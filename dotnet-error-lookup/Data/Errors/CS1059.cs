namespace dotnet_error_lookup.Data.Errors;

public class CS1059 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1059";
    string IErrorOrWarning.Message => @"The operand of an increment or decrement operator must be a variable, property or indexer";
    string IErrorOrWarning.Explanation => @"[original] The operand of an increment or decrement operator must be a variable, property or indexer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1059";
}
