


using Microsoft.Web.WebView2.Core;

namespace AppLearn
{

    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            var env = await CoreWebView2Environment.CreateAsync(null, @"C:\WebView2Data");
            await webView21.EnsureCoreWebView2Async(env);
            webView21.Source = new Uri("https://www.google.com");
        }
    }
}
