using System;
using System.Collections.Generic;

namespace OriginalFileWebLap.Models;

public partial class MayTinh
{
    public string? TenMayTinh { get; set; }

    public string IdmayTinh { get; set; } = null!;

    public DateTime? NgaySanXuat { get; set; }

    public DateTime? NgayBaoHanh { get; set; }
}
