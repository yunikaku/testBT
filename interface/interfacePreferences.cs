using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT
{
    public interface interfacePreferences
    {
        string SaveData(string key, string value);
        string LoadData(string key);
        string FastLoad(string key);
    }
}
