namespace dotnet_error_lookup.Data.Errors;

public class CS1954 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1954";
    string IErrorOrWarning.Message => @"The best overloaded method match '{0}' for the collection initializer element cannot be used. Collection initializer 'Add' methods cannot have ref or out parameters.";
    string IErrorOrWarning.Explanation => @"[original] The best overloaded method match '{0}' for the collection initializer element cannot be used. Collection initializer 'Add' methods cannot have ref or out parameters.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1954";
}
