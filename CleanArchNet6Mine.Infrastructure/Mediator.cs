using CleanArchNet6Mine.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchNet6Mine.Infrastructure;

public class Mediator
{
	private readonly AppDbContext _context;
    public Mediator(AppDbContext context)
	{
		_context = context;
	}

	public BuildVersionDto GetBuildVersion()
	{
		var bv = _context.BuildVersions.FirstOrDefault();
		BuildVersionDto bvDto = new BuildVersionDto()
		{
			SystemInformationId = bv.SystemInformationId,
			DatabaseVersion = bv.DatabaseVersion
		};
		return bvDto;
    }
}
