namespace dotnet_error_lookup.Data.Errors;

public class CS0514 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0514";
    string IErrorOrWarning.Message => @"'{0}': static constructor cannot have an explicit 'this' or 'base' constructor call";
    string IErrorOrWarning.Explanation => @"[original] '{0}': static constructor cannot have an explicit 'this' or 'base' constructor call";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0514";
}
