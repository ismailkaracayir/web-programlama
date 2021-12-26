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
            
             context.SaveChanges();
            for (int k = 0; k < 8; k++)
            {
                sevimlidostlarUser user = new sevimlidostlarUser()
                {
                    name = FakeData.NameData.GetFirstName(),
                    surname = FakeData.NameData.GetSurname(),
                    username = $"user{k}",
                    email = FakeData.NetworkData.GetEmail(),
                    password = "123",
                    IsActive = true,
                    IsAdmin = false,
                    ModifiedUsername = $"user{k}",
                    ActiveGuid = new Guid(),
               

                };
                context.SevimlidostlarUsers.Add(user);
                context.SaveChanges();


            }

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


            Hayvanlar hay = new Hayvanlar()
            {
                name = "Van kedisi",
                Description = FakeData.TextData.GetAlphabetical(150),
                ModifiedUsername=FakeData.NameData.GetFirstName(),
                  
               
            };
            context.hayvanlars.Add(hay);
            context.SaveChanges();

            Hayvanlar hay2 = new Hayvanlar()
            {
                name = "İran kedisi",
                Description = FakeData.TextData.GetAlphabetical(150),
                ModifiedUsername = FakeData.NameData.GetFirstName(),


            };
            context.hayvanlars.Add(hay2);
            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                Hayvanlar hay3 = new Hayvanlar()
                {
                    name = FakeData.NameData.GetFullName()+" "+"kedisi",
                    Description = FakeData.TextData.GetAlphabetical(150),
                    ModifiedUsername = FakeData.NameData.GetFirstName(),


                };
                context.hayvanlars.Add(hay3);
                context.SaveChanges();

                for (int j = 0; j < 5; j++)
                {
                    Comment comment = new Comment()
                    {
                         text=FakeData.TextData.GetAlphabetical(50),
                          ModifiedUsername=FakeData.NameData.GetSurname(),
                           hayvanlar=hay3,
                           

                    };
                    context.comments.Add(comment);
                    context.SaveChanges();

                    
                }
            
            }
            

        }
    }
}
