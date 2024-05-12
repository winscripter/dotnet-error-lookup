namespace dotnet_error_lookup.Data.Errors;

public class CS0274 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0274";
    string IErrorOrWarning.Message => @"Cannot specify accessibility modifiers for both accessors of the property or indexer '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify accessibility modifiers for both accessors of the property or indexer '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0274";
}
