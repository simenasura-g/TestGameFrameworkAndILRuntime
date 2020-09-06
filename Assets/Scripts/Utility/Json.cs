using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameFramework {
    public static partial class Utility {
        public static partial class Json {
            public static string ReadJsonFromPath(string path) {
                var rpath = Path.GetRegularPath(path);
                var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                var json = string.Empty;
                using (var sr = new StreamReader(fs)) {
                    json = sr.ReadToEnd();
                    sr.Close();
                }
                Log.c(json);
                fs.Close();
                return json;
            }
        }
    }
}
