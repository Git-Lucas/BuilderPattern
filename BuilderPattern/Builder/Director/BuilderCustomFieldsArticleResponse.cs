using BuilderPattern.Entities;

namespace BuilderPattern.Builder.Director;
public class BuilderCustomFieldsArticleResponse(Article article) : IBuilderCustomFieldsArticleResponse
{
    private Article _articleResponse = new();
    private readonly Article _article = article;

    public void Reset()
    {
        _articleResponse = new();
    }

    public void BuildTitle()
    {
        _articleResponse.Title = _article.Title;
    }

    public void BuildIntroduction()
    {
        _articleResponse.Introduction = _article.Introduction;
    }

    public void BuildBody()
    {
        _articleResponse.Body = _article.Body;
    }

    public void BuildMethods()
    {
        _articleResponse.Methods = _article.Methods;
    }

    public void BuildConclusion()
    {
        _articleResponse.Conclusion = _article.Conclusion;
    }

    public Article GetArticle()
    {
        Article result = _articleResponse;
        Reset();
        return result;
    }
}
