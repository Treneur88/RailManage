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
    public class DetailsModel : PageModel
    {
        private readonly RailManage.Data.RailManageContext _context;

        public DetailsModel(RailManage.Data.RailManageContext context)
        {
            _context = context;
        }

        public Train Train { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var train = await _context.Train.FirstOrDefaultAsync(m => m.TrainId == id);
            if (train == null)
            {
                return NotFound();
            }
            else
            {
                Train = train;
            }
            return Page();
        }
    }
}
