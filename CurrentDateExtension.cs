using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Activity02
{
    public class CurrentDateExtension : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"Welcome to CJ Project! Today is {DateTime.Now:MMMM dd, yyyy}";
        }
    }
}

