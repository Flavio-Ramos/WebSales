using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB has been seeded(bd já populado)
            }

            Department d1 = new Department( "Computers");
            Department d2 = new Department( "Electronics");
            Department d3 = new Department( "Fashion");
            Department d4 = new Department( "Books");

            Seller s1 = new Seller("Bob Brow", "bob@gmail.com", new DateTime(1994, 4, 21), 1000.0, d1);
            Seller s2 = new Seller("Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller("Alex Green", "alexGreen@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller("Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller("Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller("Alex Pink", "alexPink@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(new DateTime(2018, 9, 25), 11000.0,SalesStatus.Billed,s1);
            SalesRecord r2 = new SalesRecord(new DateTime(2018, 9, 26), 3000.0, SalesStatus.Pending, s3);
            SalesRecord r3 = new SalesRecord(new DateTime(2018, 9, 27), 16000.0, SalesStatus.Canceled, s5);
            SalesRecord r4 = new SalesRecord(new DateTime(2018, 9, 28), 32000.0, SalesStatus.Pending, s2);
            SalesRecord r5 = new SalesRecord(new DateTime(2018, 9, 29), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r6 = new SalesRecord(new DateTime(2018, 9, 30), 14000.0, SalesStatus.Billed, s6);

            SalesRecord r7 = new SalesRecord(new DateTime(2018, 8, 25), 9000.0, SalesStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(new DateTime(2018, 8, 26), 7000.0, SalesStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(new DateTime(2018, 8, 27), 13000.0, SalesStatus.Billed, s5);
            SalesRecord r10 = new SalesRecord(new DateTime(2018, 8, 28), 3000.0, SalesStatus.Billed, s2);
            SalesRecord r11 = new SalesRecord(new DateTime(2018, 8, 29), 5000.0, SalesStatus.Billed, s4);
            SalesRecord r12 = new SalesRecord(new DateTime(2018, 8, 30), 19000.0, SalesStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,
                r9,r10,r11,r12);

            _context.SaveChanges();
        }
    }
}
