using sevimlidostlar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.BusinessLayer
{

    public class Test
    {
       private Repository<Hayvanlar> repo = new Repository<Hayvanlar>();
        private Repository<Kategori> repo_kategori = new Repository<Kategori>();
        private Repository<Comment> repo_comment = new Repository<Comment>();
        private Repository<sevimlidostlarUser> repo_user = new Repository<sevimlidostlarUser>();





        public Test()
        {
            List<Hayvanlar> Liste = repo.List();
        }

        public void insert_test()
        {
            int result = repo.Insert(new Hayvanlar()
            {
                name = "ali kedisi",
                Description = "veliaaaaaaaaaaaaaaa",
                ModifiedUsername = "maliiiii",
            });
        }
        public void Update_test()
        {
            Hayvanlar hay = repo.Find(x => x.name == "ali kedisi");
            if (hay !=null)
            {
                hay.name = "veli kedisi";
                repo.Save();
            }
        }
        public void Delete_test()
        {
            Hayvanlar hay = repo.Find(x => x.name == "veli kedisi");
            if (hay != null)
            {
                repo.Delete(hay);
            }

        }
        public  void Comment_test()
        {
            Hayvanlar hayvanlar = repo.Find(x => x.Id == 1);
            Comment comment = new Comment() {
                text = "bu bir test yazısı",
                ModifiedUsername="ismail",
                 hayvanlar=hayvanlar,



            };
            repo_comment.Insert(comment); 

        }
    }
}
