using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Computers.Models;

public class Computer
{
    public int Id { get; set; }

    [DisplayName("Marka komputera")]
    [Required(ErrorMessage = "Pole jest wymagane")]
    public string? Brand { get; set; }

    [DisplayName("Model komputera")]
    [Required(ErrorMessage = "Pole jest wymagane")]
    public string? Model { get; set; }

    [DisplayName("Rok produkcji")]
    [Required(ErrorMessage = "Pole jest wymagane")]
    public int? Year { get; set; }
}