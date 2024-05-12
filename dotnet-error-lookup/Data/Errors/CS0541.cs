namespace dotnet_error_lookup.Data.Errors;

public class CS0541 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0541";
    string IErrorOrWarning.Message => @"'{0}': explicit interface declaration can only be declared in a class, record, struct or interface";
    string IErrorOrWarning.Explanation => @"[original] '{0}': explicit interface declaration can only be declared in a class, record, struct or interface";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0541";
}
