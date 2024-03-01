using System;
using System.Collections.Generic;

namespace HotelWpfApp.Models;

public partial class Booking
{
    public long Id { get; set; }

    public long RoomId { get; set; }

    public byte[] DateStart { get; set; } = null!;

    public byte[] DateEnd { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
