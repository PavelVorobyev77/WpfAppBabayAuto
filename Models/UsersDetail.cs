using System;
using System.Collections.Generic;

namespace WpfAppBabayAuto.Models;

public partial class UsersDetail
{
    public long IdDetail { get; set; }

    public long IdUser { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Patronymic { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
