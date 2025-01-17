﻿using System;
using System.Collections.Generic;

namespace WpfAppBabayAuto.Models;

public partial class User
{
    public long IdUser { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<UsersDetail> UsersDetails { get; set; } = new List<UsersDetail>();
}
