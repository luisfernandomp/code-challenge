using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Response
{
    public class PagedResultBase
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int ItensPerPage { get; set; }
        public int RowCount { get; set; }

        public int FirstRowOnPage
        {

            get { return (CurrentPage - 1) * ItensPerPage + 1; }
        }

        public int LastRowOnPage
        {
            get { return Math.Min(CurrentPage * ItensPerPage, RowCount); }
        }
    }
}
