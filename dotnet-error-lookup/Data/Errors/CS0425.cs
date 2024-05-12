namespace dotnet_error_lookup.Data.Errors;

public class CS0425 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0425";
    string IErrorOrWarning.Message => @"The constraints for type parameter '{0}' of method '{1}' must match the constraints for type parameter '{2}' of interface method '{3}'. Consider using an explicit interface implementation instead.";
    string IErrorOrWarning.Explanation => @"[original] The constraints for type parameter '{0}' of method '{1}' must match the constraints for type parameter '{2}' of interface method '{3}'. Consider using an explicit interface implementation instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0425";
}
