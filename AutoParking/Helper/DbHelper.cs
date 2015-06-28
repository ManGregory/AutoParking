using System;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace AutoParking.Helper
{
    public static class DbHelper
    {
        /// <summary>
        /// Сохранение информации в базу
        /// </summary>
        /// <param name="db"></param>
        public static void Save(DbContext db)
        {
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
