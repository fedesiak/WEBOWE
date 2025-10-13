using System;
using System.Text.Json;
using System.Linq;

namespace Computers.Models;

public class FileComputersRepo : IComputersRepo
{
    private readonly string filePath = "computers.json";
    private List<Computer> _computers;

    private void LoadComputersFromFile()
    {
        if (!File.Exists(filePath))
        {
            _computers = new List<Computer>();
            return;
        }
        var result = File.ReadAllText(filePath);
        _computers = JsonSerializer.Deserialize<List<Computer>>(result) 
                     ?? new List<Computer>();
    }

    public FileComputersRepo()
    {
        LoadComputersFromFile();
        Computers = _computers;
    }

    public List<Computer> Computers { get; set; }

    public void AddComputer(Computer computer)
    {
        computer.Id = GetNextId();
        Computers.Add(computer);
        SaveToFile();
    }

    private void SaveToFile()
    {
        var json = JsonSerializer.Serialize(Computers);
        File.WriteAllText(filePath, json);
    }

    public List<Computer> GetAllComputers()
    {
        return Computers;
    }

    public Computer? GetComputer(int id)
    {
        return Computers.FirstOrDefault(c => c.Id == id);
    }

    public void RemoveComputer(int id)
    {
        var computerToRemove = GetComputer(id);
        if (computerToRemove is not null)
        {
            Computers.Remove(computerToRemove);
            SaveToFile();
        }
    }

    private int GetNextId()
    {
        if (Computers.Count == 0) return 1;
        return Computers.Max(c => c.Id) + 1;
    }

    public void UpdateComputer(Computer computer)
    {
        var computerToUpdate = GetComputer(computer.Id);
        if (computerToUpdate is not null)
        {
            computerToUpdate.Brand = computer.Brand;
            computerToUpdate.Model = computer.Model;
            computerToUpdate.Year = computer.Year;
            SaveToFile();
        }
    }
}