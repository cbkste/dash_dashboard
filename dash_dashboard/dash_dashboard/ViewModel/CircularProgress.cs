using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dash_dashboard.ViewModel
{
    public class CircularProgress
    {
        public int Percentage { get; }
        public string CssClass
        {
            get
            {
                return Percentage > 50 ? "orange" : "blue";
            }
        }
        public CircularProgress(int percentage)
        {
            Percentage = percentage;
        }
    }
}

