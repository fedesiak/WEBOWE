using System.Collections.Generic;

namespace Computers.Models;

public interface IComputersRepo
{
    List<Computer> Computers { get; set; }
    Computer? GetComputer(int id);
    void AddComputer(Computer computer);
    void RemoveComputer(int id);
    List<Computer> GetAllComputers();
    void UpdateComputer(Computer computer);
}