namespace dotnet_error_lookup.Data.Errors;

public class CS0664 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0664";
    string IErrorOrWarning.Message => @"Literal of type double cannot be implicitly converted to type '{1}'; use an '{0}' suffix to create a literal of this type";
    string IErrorOrWarning.Explanation => @"[original] Literal of type double cannot be implicitly converted to type '{1}'; use an '{0}' suffix to create a literal of this type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0664";
}
