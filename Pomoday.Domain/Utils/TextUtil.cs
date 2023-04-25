using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Utils
{
    public static class TextUtil
    {
        public static Guid? ToInt(this string value)
        {
            Guid result;
            if (Guid.TryParse(value, out result))
                return result;
            return null;
        }
    }
}
