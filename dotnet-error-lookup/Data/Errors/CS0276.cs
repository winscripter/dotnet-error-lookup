namespace dotnet_error_lookup.Data.Errors;

public class CS0276 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0276";
    string IErrorOrWarning.Message => @"'{0}': accessibility modifiers on accessors may only be used if the property or indexer has both a get and a set accessor";
    string IErrorOrWarning.Explanation => @"[original] '{0}': accessibility modifiers on accessors may only be used if the property or indexer has both a get and a set accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0276";
}
