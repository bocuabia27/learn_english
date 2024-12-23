using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.KHCN
{
    [Route("api/khcn/[controller]")]
    [ApiController]
    public class VNhiemVuKHCNController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public VNhiemVuKHCNController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VNhiemVuKHCN
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbNhiemVuKhcn>>> GetVNhiemVuKHCNs()
        {
            return await _context.TbNhiemVuKhcns.ToListAsync();
        }

        // GET: api/VNhiemVuKHCN/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbNhiemVuKhcn>> GetVNhiemVuKHCN(int id)
        {
            var VNhiemVuKHCN = await _context.TbNhiemVuKhcns.FindAsync(id);

            if (VNhiemVuKHCN == null)
            {
                return NotFound();
            }

            return VNhiemVuKHCN;
        }

    }
}
