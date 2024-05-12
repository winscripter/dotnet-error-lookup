namespace dotnet_error_lookup.Data.Errors;

public class CS7022 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7022";
    string IErrorOrWarning.Message => @"The entry point of the program is global code; ignoring '{0}' entry point.";
    string IErrorOrWarning.Explanation => @"[original] The entry point of the program is global code; ignoring '{0}' entry point.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
