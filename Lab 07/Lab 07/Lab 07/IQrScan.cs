using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public interface IQrScan
    {
        Task<string> ScanAsync();
    }
}
