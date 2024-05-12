namespace dotnet_error_lookup.Data.Errors;

public class CS1913 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1913";
    string IErrorOrWarning.Message => @"Member '{0}' cannot be initialized. It is not a field or property.";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' cannot be initialized. It is not a field or property.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1913";
}
