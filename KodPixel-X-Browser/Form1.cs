namespace KodPixel_X_Browser;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

public partial class Form1 : Form
{
    private WebView2 webView2;
    public Form1()
    {
        InitializeComponent();
        this.Text = "KodPixel-X-Browser";
        this.Width = 950;
        this.Height = 960;

        TextBox textBox = new TextBox();
        textBox.Dock = DockStyle.Bottom;
        textBox.Location = new Point(10, 10);
        webView2 = new WebView2();
        webView2.Dock = DockStyle.Fill;
        this.Load += Form_Load;
        this.Controls.Add(webView2);
        this.Controls.Add(textBox);
        textBox.BringToFront();
    }

    private async void Form_Load(object sender, EventArgs e)
    {
        await webView2.EnsureCoreWebView2Async();
        webView2.CoreWebView2.Navigate("https://kodpixel-x.github.io/KodPixel-X-Browser/");
    }
}
