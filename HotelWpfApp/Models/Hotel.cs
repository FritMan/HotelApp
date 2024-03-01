using System;
using System.Collections.Generic;

namespace HotelWpfApp.Models;

public partial class Hotel
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long RegionId { get; set; }

    public virtual Region Region { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
