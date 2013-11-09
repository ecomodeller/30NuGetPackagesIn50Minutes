namespace WindowsFormsApplication1.Entities
{
    public enum RuleAction
    {
        Text,
        Video
    }

    public enum RuleLanguage
    {
        CSharp,
        Ruby,
        Python,
        JavaScript,
        Scheme
    }

    public enum ExportTargets
    {
        String,
        PDF,
        Excel,
        Json,
        CSV,
        Ini
    }
}