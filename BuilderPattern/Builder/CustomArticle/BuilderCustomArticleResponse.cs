using BuilderPattern.Entities;

namespace BuilderPattern.Builder.CustomArticle;
public class BuilderCustomArticleResponse
{
    private Article _article;

    private const string DefaultTitle = "Default Title";
    private const string DefaultIntroduction = "Default Introduction";
    private const string DefaultBody = "Default Body";
    private const string DefaultMethods = "Default Methods";
    private const string DefaultConclusion = "Default Conclusion";

    public BuilderCustomArticleResponse()
    {
        _article = Init();
    }

    private static Article Init()
    {
        return new Article()
        {
            Title = DefaultTitle,
            Introduction = DefaultIntroduction,
            Body = DefaultBody,
            Methods = DefaultMethods,
            Conclusion = DefaultConclusion
        };
    }

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

        _article = Init();

        return result;
    }
}
