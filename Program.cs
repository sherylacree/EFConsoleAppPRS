
using Microsoft.EntityFrameworkCore;
namespace EFConsoleApp;

internal class Program {

    static void Main(string[] args) {
        var context = new AppDbContext();

        var requests = context.RequestLines.Include(x => x.Product).Include(x=> x.Request).ToList();
        
        requests.ForEach(x => Console.WriteLine($"{x.Request!.Description} | Product Name: {x.Product!.Name} |Product Id : {x.Product!.Id} | Total Price:  {x.Quantity * x.Product!.Price :C} | Price : {x.Product!.Price:C} |Request Id: {x.Request!.Id}"));

        var total = context.RequestLines.Include(x => x.Product).Sum(x => x.Quantity * x.Product!.Price);
        Console.WriteLine($"Total: {total:C}");
        }
    }



