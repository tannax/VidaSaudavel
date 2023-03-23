using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hotsite.Models
{
    public class DatabaseService
    {
        public bool CadastraInteresse(Interesse cad)
        {
            try
            {
                using(var context = new DatabaseContext())
                {
                    context.Add(cad);
                    context.SaveChanges();
                    return true; // Return true if the operation is successful
                }
            }
            catch (Exception)
            {
                // Handle the exception here or re-throw it to the calling code
                return false; // Return false if the operation fails
            }
        }
    }
}
