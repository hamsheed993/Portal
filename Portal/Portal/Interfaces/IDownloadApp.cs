﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Interfaces
{
    public interface IDownloadApp
    {
        bool DownloadApplication(string uri, string fileName);
    }
}
