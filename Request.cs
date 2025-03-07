﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleApp;
public class Request {
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Justification {  get; set; } = string.Empty;  
    public string? RejectionReason { get; set; } = string.Empty;

    public string DeliveryMode { get; set; } = string.Empty;
    public decimal Total {  get; set; } = 0;    
    public int UserId { get; set; }
    public virtual User? User { get; set; }


}
