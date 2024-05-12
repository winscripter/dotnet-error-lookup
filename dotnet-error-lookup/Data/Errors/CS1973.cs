namespace dotnet_error_lookup.Data.Errors;

public class CS1973 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1973";
    string IErrorOrWarning.Message => @"'{0}' has no applicable method named '{1}' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' has no applicable method named '{1}' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
