﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Execution;

namespace Registration_signUp_app.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string Firstname {  get; set; }
    public string Lastname { get; set; }
    public int   Moblienumber {  get; set; }

}

