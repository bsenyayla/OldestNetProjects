using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Data;

namespace InterfaceApp.Cache
{
    public partial class RuntimeCacheFrm : Form
    {
        public RuntimeCacheFrm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //ObjectCache _cache = MemoryCache.Host = "SiparisDirektAPI";



            //List<string> cacheKeys = _cache.Select(kvp => kvp.Key).ToList();

            //gridKey.DataSource = cacheKeys;



            //foreach (string cacheKey in cacheKeys)
            //{
            //    _cache.Remove(cacheKey);
            //}
        }
    }
}
