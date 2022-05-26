using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrack.Infrastructure.Data {
	public class ITDbContext : DbContext {
		public ITDbContext(DbContextOptions<ITDbContext> options) : base(options) { }
	}
}
