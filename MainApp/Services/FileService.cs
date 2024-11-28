using MainApp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MainApp.Services;

public class FileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;

    public FileService(string directoryPath = "Data", string fileName = "list.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    }

    public void SaveListToFile(List<User> list)
    {
        if (!Directory.Exists(_directoryPath))
        {
            Directory.CreateDirectory(_directoryPath);
        }

        var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true});

        File.WriteAllText(_filePath, json);
    }

    public List<User> LoadListFromFile() 
    {

    }
}
