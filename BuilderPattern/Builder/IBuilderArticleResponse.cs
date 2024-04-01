namespace BuilderPattern.Builder;
public interface IBuilderArticleResponse
{
    void BuildTitle();
    void BuildIntroduction();
    void BuildBody();
    void BuildMethods();
    void BuildConclusion();
}
