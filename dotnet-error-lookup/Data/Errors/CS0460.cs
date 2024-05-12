namespace dotnet_error_lookup.Data.Errors;

public class CS0460 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0460";
    string IErrorOrWarning.Message => @"Constraints for override and explicit interface implementation methods are inherited from the base method, so they cannot be specified directly, except for either a 'class', or a 'struct' constraint.";
    string IErrorOrWarning.Explanation => @"[original] Constraints for override and explicit interface implementation methods are inherited from the base method, so they cannot be specified directly, except for either a 'class', or a 'struct' constraint.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0460";
}
