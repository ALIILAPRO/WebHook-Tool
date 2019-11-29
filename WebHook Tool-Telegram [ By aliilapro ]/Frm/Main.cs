using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace WebHook_Tool_Telegram___By_aliilapro__.Frm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void h_token_CheckedChanged(object sender, EventArgs e)
        {
            bool @true = this.h_token.Checked;
            if (@true)
            {
                txt_token.PasswordChar = '0';
            }
            else
            {
                txt_token.PasswordChar = '\0';
            }
        }

        private void h_url_CheckedChanged(object sender, EventArgs e)
        {
            bool @true = this.h_url.Checked;
            if (@true)
            {
                txt_url.PasswordChar = 'w';
            }
            else
            {
                txt_url.PasswordChar = '\0';
            }
        }
        private void r_set_CheckedChanged(object sender, EventArgs e)
        {
            bool @true = this.r_set.Checked;
            if (@true)
            {
                txt_url.Enabled = true;
                h_url.Enabled = true;
            }
            else
            {
                txt_url.Enabled = false;
                h_url.Enabled = false;
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            bool @set = this.r_set.Checked;
            if (@set)
            {
                try
                {
                    string link_set = new WebClient().DownloadString("https://api.telegram.org/bot" + this.txt_token.Text + "/setwebhook?url=" + this.txt_url.Text);
                    JObject json_set = JObject.Parse(link_set);
                    string description = json_set["description"].ToString();
                    txtlog.Text = string.Concat(new object[]
                    {
                        txtlog.Text,"-----------------------------\r\n[+]info: ",description,"\r\n-----------------------------\r\n"
                    });
                }
                catch
                {
                    txtlog.Text = string.Concat(new object[]
                    {
                             txtlog.Text,"-----------------------------\r\n[+]Error:\r\nCheck [Token or Internet] And Try Again To Set Webhook.\r\n-----------------------------\r\n"
                    });
                }
            }
            else
            {
                bool del = this.r_del.Checked;
                if (del)
                {
                    try
                    {
                        string link_del = new WebClient().DownloadString("https://api.telegram.org/bot" + this.txt_token.Text + "/deletewebhook");
                        JObject json_del = JObject.Parse(link_del);
                        string description = json_del["description"].ToString();
                        txtlog.Text = string.Concat(new object[]
                        {
                        txtlog.Text,"-----------------------------\r\n[+]info: ",description,"\r\n-----------------------------r\n"
                        });
                    }
                    catch
                    {
                        txtlog.Text = string.Concat(new object[]
                        {
                             txtlog.Text,"-----------------------------\r\n[+]Error:\r\nCheck [Token or Internet] And Try Again To Delete Webhook.\r\n-----------------------------\r\n"
                        });
                    }
                }
                else
                {
                    bool info = this.r_info.Checked;
                    if (info)
                    {
                        try
                        {
                            string link_getme = new WebClient().DownloadString("https://api.telegram.org/bot" + this.txt_token.Text + "/getme");
                            JObject json_getme = JObject.Parse(link_getme);
                            string link_getwebhookinfo = new WebClient().DownloadString("https://api.telegram.org/bot" + this.txt_token.Text + "/getwebhookinfo");
                            JObject json_getwebhookinfo = JObject.Parse(link_getwebhookinfo);
                            string id = json_getme["result"]["id"].ToString();
                            string firstname = json_getme["result"]["first_name"].ToString();
                            string username = json_getme["result"]["username"].ToString();
                            string url = json_getwebhookinfo["result"]["url"].ToString();
                            txtlog.Text = string.Concat(new string[]
                            {
                            txtlog.Text,"-----------------------------\r\nBot Information :\r\n[+]id : ",id,"\r\n[+]firstname : ",firstname,"\r\n[+]username : ",username,"\r\n[+]url : ",url,"\r\n-----------------------------\r\n"
                            });
                        }
                        catch
                        {
                            txtlog.Text = string.Concat(new object[]
                            {
                             txtlog.Text,"-----------------------------\r\n[+]Error:\r\nCheck [Token or Internet] And Try Again To Get Info.\r\n-----------------------------\r\n"
                            });
                        }
                    }
                }
            }
        }
    }
}
