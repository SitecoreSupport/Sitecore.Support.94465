namespace Sitecore.Support.Pipelines.RenderField
{
    using Sitecore.Pipelines.RenderField;

    public class ProtectedImageLinkRenderer : Sitecore.Pipelines.RenderField.ProtectedImageLinkRenderer
    {
        public new void Process(RenderFieldArgs args)
        {
            if (Sitecore.Context.PageMode.IsExperienceEditor) // don't add hash in Experience Editor
            {
                return;
            }
            base.Process(args);
        }
    }
}