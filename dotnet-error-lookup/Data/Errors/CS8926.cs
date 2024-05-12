namespace dotnet_error_lookup.Data.Errors;

public class CS8926 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8926";
    string IErrorOrWarning.Message => @"A static virtual or abstract interface member can be accessed only on a type parameter.";
    string IErrorOrWarning.Explanation => @"[original] A static virtual or abstract interface member can be accessed only on a type parameter.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
