using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FuckTiktok
{
    
    class Tiktok
    {
        private static readonly HttpClient Client = new HttpClient(new HttpClientHandler() { UseCookies = false });
        private static readonly Random rand = new Random();
        public int CountThreading = 5;
        public int RandomLength = 4;
        int Done,Unknown,Bad,Valid = 0;
        private const int NumberOfRetries = 10;
        private const int DelayOnRetry = 200;
        public bool requestCanellation = false;
        long counts = 0;
        string[] users = null;
        public string Cookies = null;
        public static string id, token = "";

        public void setup()
        {
            Done = 0;Unknown = 0;Bad = 0;Valid = 0;counts=0 ;
            Client.DefaultRequestHeaders.Add("Cookie", this.Cookies);

        }
        public async Task StartTasks(Control LabelCountChecked, Control StatusLabel,Control  ValidControl,Control BadControl,Control UnknownControl ,Control Initiator,Control ResultArea, bool random = true, string[] users = null)
        {
            try
            {
                List<Task> AllTasks = new List<Task>();
                if (random)
                {
                    while (true)
                    {
                        for (var x = 0; x < this.CountThreading; x++)
                        {
                            if (this.requestCanellation) break;
                            Task task = this.AsyncRequest(this.RandomUser(this.RandomLength), LabelCountChecked, UnknownControl, BadControl, ValidControl, ResultArea);
                            counts++;
                            AllTasks.Add(task);
                        }
                        await Task.WhenAll(AllTasks);
                        AllTasks.Clear();
                        if (this.requestCanellation) break;
                    }
                }
                else
                {
                    this.users = users;
                    bool reached_end = false;
                    while (true)
                    {
                        for (var x = 0; x < this.CountThreading; x++)
                        {
                            if (counts == this.users.Length)
                            {
                                reached_end = true;
                                break;
                            }
                            Task task = this.AsyncRequest(users[counts], LabelCountChecked, UnknownControl, BadControl, ValidControl, ResultArea);
                            counts++;
                            AllTasks.Add(task);
                        }
                        await Task.WhenAll(AllTasks);
                        AllTasks.Clear();
                        if (reached_end || this.requestCanellation)
                        {
                            StatusLabel.Invoke(new Action(() => StatusLabel.Text = "End"));
                            break;
                        }
                    }
                }
                MainForm.is_busy = false;
                update_text(Initiator, "Start check");
            }
            catch
            {
                // im tired i know i should try and catch the error inside the loop but IM TIRED :(
            }
        }
        static void SendValid(string user)
        {
            if (id == "" || token == "") return;
            Client.GetAsync("https://api.telegram.org/bot" + token + "/sendMessage?" + "chat_id=" + id + "&text=" + Uri.EscapeUriString("New Username : " + user + "\n Created By @YU5UY 3>"));
        }
        void update_text(Control to_update,dynamic Value)
        {
            to_update.Invoke(new Action(() => to_update.Text = Value.ToString()));
        }
        void WriteToFile(string file_name,string username)
        {

            for (int i = 1; i <= NumberOfRetries; ++i)
            {
                try
                {
                    using (StreamWriter write = File.AppendText(file_name))
                    {
                        write.WriteLine(username);
                        write.Close();
                    }
                    break;
                }
                catch (IOException e) when (i <= NumberOfRetries)
                {
                    System.Threading.Thread.Sleep(DelayOnRetry);
                }
            }
            
        }
        async Task AsyncRequest(string username, Control LabelCountChecked, Control UnknownControl, Control Bad, Control Valid,dynamic ResultArea)
        {
            if (username == "" || username.Contains("\n") || username.Contains("\r")) return;
            string response = await Client.GetStringAsync("https://www.tiktok.com/api/uniqueid/check/?aid=1233&app_name=tiktok_web&app_language=en&device_platform=web_pc&region=PS&os=windows&referer=https:%2F%2Fwww.bing.com%2F&root_referer=&cookie_enabled=true&screen_width=1680&screen_height=1050&browser_language=ar&browser_platform=Win32&browser_name=Mozilla&browser_version=5.0%20(Windows%20NT%2010.0%3B%20Win64%3B%20x64)%20AppleWebKit%2F537.36%20(KHTML%2C%20like%20Gecko)%20Chrome%2F99.0.4844.74%20Safari%2F537.36%20Edg%2F99.0.1150.46&browser_online=true&timezone_name=Asia%2FHebron&is_page_visible=true&focus_state=true&is_fullscreen=false&history_len=4&battery_info=1&unique_id=" + username);
            dynamic json = JsonConvert.DeserializeObject(response);
            string is_valid = json.is_valid;

            if (is_valid == "True")
            {
                this.Valid++;
                update_text(Valid, this.Valid);
                ResultArea.Invoke(new Action(() =>
                {
                    ResultArea.Text += "New user => " + username + " - by t.me/yu5uy" + Environment.NewLine;
                    ResultArea.SelectionStart = ResultArea.Text.Length;
                    ResultArea.ScrollToCaret();
                }));
                SendValid(username);
                WriteToFile("Valid.txt", username);

            }
            else if (is_valid == "False")
            {
                this.Bad++;
                update_text(Bad, this.Bad);
            }
            else
            {
                this.Unknown++;
                update_text(UnknownControl, this.Unknown);
                WriteToFile("Unknwon.txt", username);
            }
            Done += 1;
            LabelCountChecked.Invoke(new Action(() => LabelCountChecked.Text = counts.ToString()));
        }
        
        string RandomUser(int LengthUser)
        {
            string User = "";
            string chars = "abcdefghigklmnopqrstuvwxyz._0123456789";
            for (var x = 0; x < LengthUser; x++) User += chars[rand.Next(36)];
            return User;
        }
    }
}
