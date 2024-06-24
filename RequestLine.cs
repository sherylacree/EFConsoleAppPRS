﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleApp;
public class RequestLine {
    public int Id { get; set; }
    public int Quantity {  get; set; }
    public int RequestId { get; set; }
    public virtual Request? Request { get; set; }
    public int ProductId {  get; set; }  
    public virtual Product? Product { get; set; }


}
