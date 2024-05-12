namespace dotnet_error_lookup.Data.Errors;

public class CS0513 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0513";
    string IErrorOrWarning.Message => @"'{0}' is abstract but it is contained in non-abstract type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is abstract but it is contained in non-abstract type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0513";
}
