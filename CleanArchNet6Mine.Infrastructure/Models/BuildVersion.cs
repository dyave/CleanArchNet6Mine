using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchNet6Mine.Infrastructure.Models;
public class BuildVersion
{
    public byte SystemInformationId { get; set; }
    public string DatabaseVersion { get; set; } = null!;
    public DateTime VersionDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
