using System;
using System.Collections.Generic;

namespace RamosFloresPC02.API.Infrastructure.Data
{
    public partial class EmployeeReports
    {
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public string? ReportNumber { get; set; }
        public string? ReportDescription { get; set; }

        public virtual ReportsDesc? ReportsDesc { get; set; }
    }
}
