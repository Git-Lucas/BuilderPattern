using BuilderPattern.Entities;

namespace BuilderPattern.Builder.DefaultArticle;
public class BuilderExerciseArticleResponse
{
    public static Article Build()
    {
        Article _article = new()
        {
            Title = "The Benefits of Regular Exercise",
            Introduction = "Regular exercise is essential for good health. In this article, we'll explore " +
                           "why it's crucial to make exercise a priority.",
            Body = "Improved Physical Health: Exercise improves cardiovascular health, strengthens muscles" +
                   " and bones, aids in weight management, and lowers the risk of chronic diseases like " +
                   "heart disease and diabetes.\r\n\r\nEnhanced Mental Well-being: Exercise releases endorphins," +
                   " reducing stress, anxiety, and depression. It boosts mood, increases energy, and improves " +
                   "cognitive function.\r\n\r\nBetter Sleep Quality: Regular physical activity improves sleep " +
                   "quality and duration by regulating the sleep-wake cycle and promoting relaxation.",
            Methods = "This article is based on a review of research studies and expert opinions on exercise " +
                      "benefits. Information was gathered from academic databases, peer-reviewed articles, and " +
                      "consultations with health professionals.",
            Conclusion = "Regular exercise offers numerous benefits for physical and mental health. By " +
                         "incorporating it into your routine, you can improve overall well-being, reduce " +
                         "disease risk, boost mood, and enjoy better sleep."
        };

        return _article;
    }
}
