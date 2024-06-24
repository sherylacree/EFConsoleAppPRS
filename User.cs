﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp;
public class User {
    public int Id { get; set; } 
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; }= string.Empty;
    public string? Phone { get; set; }  
    public string? Email { get; set; }   
    public bool IsReviewer { get; set; }
    public bool IsAdmin { get; set; }
}//end of class



