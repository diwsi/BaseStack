using BookManagementModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Book.DTO
{
    /// <summary>
    /// DTO for clients
    /// </summary>
    public class BooksDTO : DTOBase
    {
        public override string IndexName
        {
            get
            {
                return "books";
            }
        }

        

        public string Title { get; set; }
        public string Description { get; set; }

        
    }
}
