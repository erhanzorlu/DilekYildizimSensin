﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilekYildizimSensin.Models
{
    public class AppUserClaim : IdentityUserClaim<Guid> , IBaseEntity
    {
    }
}
