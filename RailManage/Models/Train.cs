using System.ComponentModel.DataAnnotations;

namespace RailManage.Models;

public class Train
{
    public int TrainId { get; set; }
    public string? TrainName { get; set; }
    public string? TrainStartLocation { get; set; }
    public string? TrainDestinationLocation { get; set; }
    public int TrainCapacity { get; set; }
    public int NoOfBoggies { get; set; }
    public decimal TicketPrice { get; set; }
}