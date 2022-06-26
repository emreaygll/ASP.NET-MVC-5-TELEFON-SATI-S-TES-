using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kullanicis = new List<Kullanici>()
            {
              new Kullanici() {admin="admin",sifre="admin"},

            };
            
            context.SaveChanges();
            base.Seed(context);
        }
    }
}