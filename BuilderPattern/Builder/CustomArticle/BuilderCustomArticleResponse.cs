using BuilderPattern.Entities;

namespace BuilderPattern.Builder.CustomArticle;
public class BuilderCustomArticleResponse
{
    private Article _article = new();

    public BuilderCustomArticleResponse WithTitle(string title)
    {
        _article.Title = title;
        return this;
    }

    public BuilderCustomArticleResponse WithIntroduction(string introduction)
    {
        _article.Introduction = introduction;
        return this;
    }

    public BuilderCustomArticleResponse WithBody(string body)
    {
        _article.Body = body;
        return this;
    }

    public BuilderCustomArticleResponse WithMethods(string methods)
    {
        _article.Methods = methods;
        return this;
    }

    public BuilderCustomArticleResponse WithConclusion(string conclusion)
    {
        _article.Conclusion = conclusion;
        return this;
    }

    public Article Build()
    {
        Article result = _article;

        _article = new();

        return result;
    }
}
