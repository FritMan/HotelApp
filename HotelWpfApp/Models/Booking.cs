using System;
using System.Collections.Generic;

namespace HotelWpfApp.Models;

public partial class Booking
{
    public long Id { get; set; }

    public long RoomId { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public virtual Room Room { get; set; } = null!;
}
