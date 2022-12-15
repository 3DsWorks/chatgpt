using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Text.Json;

namespace ChatGPT
{

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async void test() {
            string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(myDocsPath, "conversation.json");
            var client = new OpenAiClient("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");//替换你自己的apikey，别用我的，我的已经欠费了。
           
           

                string line = richTextBox2.Text;

                var response =await client.SendRequest(line, "text-davinci-002", maxTokens: 128, echo: true);

                var formattedJson = JsonSerializer.Serialize(response, options: new JsonSerializerOptions { WriteIndented = true });

                File.AppendAllText(filePath, formattedJson);
                File.AppendAllText(filePath, $",{Environment.NewLine}");
                richTextBox1.Text +="问："+richTextBox2.Text;
                richTextBox1.Text += "\n\r";
            if (response.error is Error error)
                {                  
                     richTextBox1.Text += error.message;
                     richTextBox1.Text += formattedJson;
                }
                else

                    foreach (var choice in response.choices)
                    {
                       
                        richTextBox1.Text+="你问的是："+choice.text;
                        richTextBox1.Text += "\n\r" + choice.finish_reason;                       
                    }
            richTextBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
