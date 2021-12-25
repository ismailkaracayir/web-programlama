using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using sevimlidostlar.Entities;

namespace sevimlidostlar.dataAccessLayer
{
   public  class MyInitializer :CreateDatabaseIfNotExists<DatabaseContext>

    {
        protected override void Seed(DatabaseContext context)
        {
            sevimlidostlarUser admin = new sevimlidostlarUser()
            {
                name = "ismail", surname = "karacayir", username = "karacayir",
                email = "karacayir.com", password = "1234", IsActive = true,
                IsAdmin = true,Createon=DateTime.Now,Modifiedon=DateTime.Now.AddSeconds(5),
                ModifiedUsername="ismailkaracayir",
                ActiveGuid=new Guid()
            };
            sevimlidostlarUser standartuser = new sevimlidostlarUser()
            {
                name = "mehmt",
                surname = "karacayir",
                username = "mali",
                email = "mehmetkaracayir.com",
                password = "111111234",
                IsActive = true,
                IsAdmin = false,
                Createon = DateTime.Now.AddHours(4),
                Modifiedon = DateTime.Now.AddSeconds(51),
                ModifiedUsername = "malikaracayir" ,        
                ActiveGuid = new Guid()

            };
            context.SevimlidostlarUsers.Add(admin);
            context.SevimlidostlarUsers.Add(standartuser);
            context.SaveChanges();
            //add fakedata kategori
            for (int i = 0; i < 10; i++)
            {
                Kategori kat = new Kategori()
                {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Createon = DateTime.Now,
                     ModifiedUsername="ismilkara",
                      Modifiedon= DateTime.Now
                };

            }


        }
    }
}
