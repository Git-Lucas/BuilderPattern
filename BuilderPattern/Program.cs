using BuilderPattern.Builder.CustomArticle;
using BuilderPattern.Builder.DefaultArticle;
using BuilderPattern.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

ExerciseBuilderArticleResponse exerciseBuilderArticleResponse = new();

DirectorDefaultArticleResponse directorDefaultArticleResponse = new(exerciseBuilderArticleResponse);
Console.WriteLine("Full Default Article: ");
directorDefaultArticleResponse.BuildFullArticle();
Display(exerciseBuilderArticleResponse.GetArticle());

Console.WriteLine("\nMinimal Default Article: ");
directorDefaultArticleResponse.BuildMinimalArticle();
Display(exerciseBuilderArticleResponse.GetArticle());

Console.WriteLine("\nCustom Properties Default Article: ");
exerciseBuilderArticleResponse.BuildTitle();
exerciseBuilderArticleResponse.BuildConclusion();
Display(exerciseBuilderArticleResponse.GetArticle());

Console.WriteLine("\nCustom Article: ");
Article myArticle = new BuilderCustomArticleResponse()
    .WithTitle("My title.")
    .WithBody("My body.")
    .WithConclusion("My conclusion.")
    .Build();
Display(myArticle);

void Display(Article article)
{
    JsonSerializerOptions jsonSerializerOptions = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    Console.WriteLine(JsonSerializer.Serialize(article, jsonSerializerOptions));
}