using BuilderPattern.Builder;
using BuilderPattern.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

ExerciseBuilderArticleResponse exerciseBuilderArticleResponse = new();

DirectorArticleResponse directorArticleResponse = new(exerciseBuilderArticleResponse);
Console.WriteLine("Full Article: ");
directorArticleResponse.BuildFullArticle();
Display(exerciseBuilderArticleResponse.GetArticle());

Console.WriteLine("\nMinimal Article: ");
directorArticleResponse.BuildMinimalArticle();
Display(exerciseBuilderArticleResponse.GetArticle());

Console.WriteLine("\nCustom Article: ");
exerciseBuilderArticleResponse.BuildTitle();
exerciseBuilderArticleResponse.BuildConclusion();
Display(exerciseBuilderArticleResponse.GetArticle());

void Display(Article article)
{
    JsonSerializerOptions jsonSerializerOptions = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    Console.WriteLine(JsonSerializer.Serialize(article, jsonSerializerOptions));
}