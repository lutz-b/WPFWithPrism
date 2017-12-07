using MVVMDesignerPrism.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDesignerPrism.Services
{
    class TestService : ITestService
    {
        public string GetNewSubtitle()
        {
            return "Other Subtitle";
        }
    }
}
