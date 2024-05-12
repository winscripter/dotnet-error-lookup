namespace dotnet_error_lookup.Data.Errors;

public class CS0409 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0409";
    string IErrorOrWarning.Message => @"A constraint clause has already been specified for type parameter '{0}'. All of the constraints for a type parameter must be specified in a single where clause.";
    string IErrorOrWarning.Explanation => @"[original] A constraint clause has already been specified for type parameter '{0}'. All of the constraints for a type parameter must be specified in a single where clause.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0409";
}
