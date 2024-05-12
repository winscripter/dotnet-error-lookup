namespace dotnet_error_lookup.Data.Errors;

public class CS0136 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0136";
    string IErrorOrWarning.Message => @"A local or parameter named '{0}' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter";
    string IErrorOrWarning.Explanation => @"[original] A local or parameter named '{0}' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0136";
}
