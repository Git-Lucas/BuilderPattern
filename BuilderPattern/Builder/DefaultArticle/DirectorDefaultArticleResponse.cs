namespace BuilderPattern.Builder.DefaultArticle;
public class DirectorDefaultArticleResponse(IBuilderDefaultArticleResponse builderArticleResponse)
{
    public void BuildFullArticle()
    {
        builderArticleResponse.BuildTitle();
        builderArticleResponse.BuildIntroduction();
        builderArticleResponse.BuildBody();
        builderArticleResponse.BuildMethods();
        builderArticleResponse.BuildConclusion();
    }

    public void BuildMinimalArticle()
    {
        builderArticleResponse.BuildTitle();
        builderArticleResponse.BuildBody();
        builderArticleResponse.BuildConclusion();
    }
}
