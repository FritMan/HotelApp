using System;
using System.Collections.Generic;

namespace HotelWpfApp.Models;

public partial class Region
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}
