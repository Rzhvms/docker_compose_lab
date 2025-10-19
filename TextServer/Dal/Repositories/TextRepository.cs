using System.Text.Json;
using Dal.Entities;
using Dal.Interfaces;

namespace Dal.Repositories;

/// <inheritdoc />
public class TextRepository : ITextRepository
{
    /// <inheritdoc />
    public async Task<TextDal> GetTextAsync()
    {
        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FileUtils", "TextFragment.json");
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("TextFragment.json не найден.", filePath);
        }
        
        var json = await File.ReadAllTextAsync(filePath);
        var textDal = JsonSerializer.Deserialize<TextDal>(json);

        if (textDal == null)
        {
            throw new Exception("Не получилось десериализовать TextFragment.json");
        }
        
        return textDal;
    }
}