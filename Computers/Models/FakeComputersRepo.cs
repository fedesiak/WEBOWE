using System;
using System.Linq;
using System.Collections.Generic;

namespace Computers.Models;

public class FakeComputersRepo : IComputersRepo
{
    private List<Computer> _computers = new List<Computer>
    {
        new Computer { Id = 1, Brand = "Dell", Model = "XPS 13", Year = 2020 },
        new Computer { Id = 2, Brand = "HP", Model = "Spectre x360", Year = 2019 },
        new Computer { Id = 3, Brand = "Lenovo", Model = "ThinkPad X1", Year = 2018 },
        new Computer { Id = 4, Brand = "Asus", Model = "ZenBook 14", Year = 2021 },
        new Computer { Id = 5, Brand = "Acer", Model = "Aspire 5", Year = 2017 }
    };

    public FakeComputersRepo()
    {
        Computers = _computers;
    }

    public List<Computer> Computers { get; set; }

    public void AddComputer(Computer computer)
    {
        computer.Id = Computers.Any() ? Computers.Max(c => c.Id) + 1 : 1;
        Computers.Add(computer);
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
        var computer = GetComputer(id);
        if (computer is not null)
        {
            Computers.Remove(computer);
        }
    }

    public void UpdateComputer(Computer computer)
    {
        var existingComputer = GetComputer(computer.Id);
        if (existingComputer is not null)
        {
            existingComputer.Brand = computer.Brand;
            existingComputer.Model = computer.Model;
            existingComputer.Year = computer.Year;
        }
    }
}