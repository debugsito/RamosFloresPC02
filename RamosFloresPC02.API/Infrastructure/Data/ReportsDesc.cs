using System;
using System.Collections.Generic;

namespace RamosFloresPC02.API.Infrastructure.Data
{
    public partial class ReportsDesc
    {
        public int ReportId { get; set; }
        public string? ReportDescription { get; set; }

        public virtual EmployeeReports Report { get; set; } = null!;
    }
}
