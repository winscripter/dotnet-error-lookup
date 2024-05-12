namespace dotnet_error_lookup.Data.Errors;

public class CS0577 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0577";
    string IErrorOrWarning.Message => @"The Conditional attribute is not valid on '{0}' because it is a constructor, destructor, operator, lambda expression, or explicit interface implementation";
    string IErrorOrWarning.Explanation => @"[original] The Conditional attribute is not valid on '{0}' because it is a constructor, destructor, operator, lambda expression, or explicit interface implementation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0577";
}
