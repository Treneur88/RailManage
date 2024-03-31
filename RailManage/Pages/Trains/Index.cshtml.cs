using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RailManage.Data;
using RailManage.Models;

namespace RailManage.Pages.Trains
{
    public class IndexModel : PageModel
    {
        private readonly RailManage.Data.RailManageContext _context;

        public IndexModel(RailManage.Data.RailManageContext context)
        {
            _context = context;
        }

        public IList<Train> Train { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Train = await _context.Train.ToListAsync();
        }
    }
}
