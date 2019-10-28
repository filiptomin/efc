using Microsoft.EntityFrameworkCore;
using MyDb.Data;
using System;
using System.Linq;

namespace MyDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            foreach (var r in db.Zavods.Include(r => r.ZavodnikZavods).OrderBy(r => r.Name).ToList())
            {
                Console.WriteLine("-- " + r.Name + " --");
                foreach (var m in r.ZavodnikZavods.OrderBy(mun => mun.Zavodnik))
                {
                    Console.WriteLine(m.Zavodnik);
                }
            }
        }
    }
}
