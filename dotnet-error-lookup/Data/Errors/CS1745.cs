namespace dotnet_error_lookup.Data.Errors;

public class CS1745 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1745";
    string IErrorOrWarning.Message => @"Cannot specify default parameter value in conjunction with DefaultParameterAttribute or OptionalAttribute";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify default parameter value in conjunction with DefaultParameterAttribute or OptionalAttribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
