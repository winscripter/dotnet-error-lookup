namespace dotnet_error_lookup.Data.Errors;

public class CS1542 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1542";
    string IErrorOrWarning.Message => @"'{0}' cannot be added to this assembly because it already is an assembly";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be added to this assembly because it already is an assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1542";
}
