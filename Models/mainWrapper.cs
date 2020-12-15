using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class MainWrapper
    {


        public Section Section { get; set; }

        public LogRecord LogRecord { get; set; }
    }
}