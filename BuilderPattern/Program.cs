using BuilderPattern.Builder.CustomArticle;
using BuilderPattern.Builder.DefaultArticle;
using BuilderPattern.Builder.Director;
using BuilderPattern.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

BuilderWithDefaultArticle();
BuilderWithCustomArticle();

void BuilderWithDefaultArticle()
{
    Article defaultArticle = BuilderExerciseArticleResponse.Build();
    BuilderCustomFieldsArticleResponse builderCustomFieldsArticleResponse = new(defaultArticle);

    DirectorCustomFieldsArticleResponse directorCustomFieldsArticleResponse = new(builderCustomFieldsArticleResponse);
    Console.WriteLine("Full Default Article: ");
    directorCustomFieldsArticleResponse.BuildFullArticle();
    Display(builderCustomFieldsArticleResponse.GetArticle());

    Console.WriteLine("\nMinimal Default Article: ");
    directorCustomFieldsArticleResponse.BuildMinimalArticle();
    Display(builderCustomFieldsArticleResponse.GetArticle());

    Console.WriteLine("\nCustom Properties Default Article: ");
    builderCustomFieldsArticleResponse.BuildTitle();
    builderCustomFieldsArticleResponse.BuildConclusion();
    Display(builderCustomFieldsArticleResponse.GetArticle());
}

void BuilderWithCustomArticle()
{
    Article myArticle = new BuilderCustomArticleResponse()
        .WithTitle("My title.")
        .WithBody("My body.")
        .WithConclusion("My conclusion.")
        .Build();
    BuilderCustomFieldsArticleResponse builderCustomFieldsArticleResponse = new(myArticle);

    DirectorCustomFieldsArticleResponse directorCustomFieldsArticleResponse = new(builderCustomFieldsArticleResponse);
    Console.WriteLine("\nFull Custom Article: ");
    directorCustomFieldsArticleResponse.BuildFullArticle();
    Display(builderCustomFieldsArticleResponse.GetArticle());

    Console.WriteLine("\nMinimal Custom Article: ");
    directorCustomFieldsArticleResponse.BuildMinimalArticle();
    Display(builderCustomFieldsArticleResponse.GetArticle());

    Console.WriteLine("\nCustom Properties Custom Article: ");
    builderCustomFieldsArticleResponse.BuildTitle();
    builderCustomFieldsArticleResponse.BuildConclusion();
    Display(builderCustomFieldsArticleResponse.GetArticle());
}

void Display(Article article)
{
    JsonSerializerOptions jsonSerializerOptions = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    Console.WriteLine(JsonSerializer.Serialize(article, jsonSerializerOptions));
}