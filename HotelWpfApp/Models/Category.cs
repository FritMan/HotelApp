using System;
using System.Collections.Generic;

namespace HotelWpfApp.Models;

public partial class Category
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
