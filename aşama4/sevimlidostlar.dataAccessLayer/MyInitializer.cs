using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using sevimlidostlar.Entities;

namespace sevimlidostlar.dataAccessLayer
{
   public  class MyInitializer :CreateDatabaseIfNotExists<DatabaseContext>//database yoksa çalışacak

    {
        protected override void Seed(DatabaseContext context)//database oluştuktan sonra data basımı yapar
        {
            sevimlidostlarUser admin = new sevimlidostlarUser()
            {
                name = "ismail",
                surname = "karacayir",
                username = "karacayir",
                email = "karacayir.com",
                password = "1234",
                IsActive = true,
                IsAdmin = true,
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
                ModifiedUsername = "malikaracayir" ,        
                ActiveGuid = new Guid()

            };
            context.SevimlidostlarUsers.Add(admin);
            context.SevimlidostlarUsers.Add(standartuser);
            for (int i = 0; i < 8; i++)
            {
                sevimlidostlarUser user = new sevimlidostlarUser()
                {
                    name = FakeData.NameData.GetFirstName(),
                    surname = FakeData.NameData.GetSurname(),
                    username = $"user{i}",
                    email = FakeData.NetworkData.GetEmail(),
                    password = "123",
                    IsActive = true,
                    IsAdmin = false,
                    ModifiedUsername = $"user{i}",
                    ActiveGuid = new Guid()

                };
                context.SevimlidostlarUsers.Add(user);


            }
             context.SaveChanges();

            //add fakedata kategori oluşumu

            Kategori kat = new Kategori()
            {
                Title = "Kedi",
                ModifiedUsername = "ismilkara",

            };
            context.kategori.Add(kat);
            Kategori kat1 = new Kategori()
            {
                Title = "Köpek",
                ModifiedUsername = "ismilkara",

            };
            context.kategori.Add(kat1);
            Kategori kat2 = new Kategori()
            {
                Title ="Diğer",
                ModifiedUsername = "ismilkara",

            };
            context.kategori.Add(kat2);
            context.SaveChanges();







        }
    }
}
