using System;
using System.Collections.Generic;

namespace HotelWpfApp.Models;

public partial class Room
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long HotelId { get; set; }

    public long CategoryId { get; set; }

    public long NumberSeats { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Category Category { get; set; } = null!;

    public virtual Hotel Hotel { get; set; } = null!;
}
