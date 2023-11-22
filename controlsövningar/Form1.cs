using System.Drawing.Imaging;
using System.Windows.Forms;

namespace controlsövningar
{
    public partial class Form1 : Form
    {

        TextBox textbox;
        Button button1;
        Button button2;
        RichTextBox richtextbox;
        RichTextBox richTextBox1;
        List<string> nameList1 = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tab1();
            tab2();
        }

        private void tab1()
        {
            textbox = new TextBox();
            textbox.Size = new Size(200, 10);
            textbox.Location = new Point(10, 10);
            tabControl1.TabPages[0].Controls.Add(textbox);
           
            button1 = new Button();
            button1.Text = ("Lägg till");
            button1.Size = new Size(100,30);
            button1.Location = new Point(textbox.Location.X,textbox.Location.Y + textbox.Height + 15);
            tabControl1.TabPages[0].Controls.Add(button1);
            button1.Click += Button1_Click;
          
            button2 = new Button();
            button2.Text = ("Sortera");
            button2.Size = new Size(button1.Size.Width,button1.Height);
            button2.Location = new Point(textbox.Location.X, button1.Location.Y + button1.Height + 5);
            tabControl1.TabPages[0].Controls.Add(button2);
            button2.Click += Button2_Click;

            richtextbox = new RichTextBox();
            richtextbox.Size = new Size(300,300);
            richtextbox.Location = new Point(textbox.Location.X + textbox.Width + 10,textbox.Location.Y);
            tabControl1.TabPages[0].Controls.Add(richtextbox);
        }

        private void tab2()
        {
           Panel panel = new Panel();
            panel.AutoSize = true;
            tabControl1.TabPages[1].Controls.Add(panel);

            ComboBox comboBox1 = new ComboBox();
            comboBox1.Location = new Point(10,50);
            panel.Controls.Add(comboBox1);

            ComboBox comboBox2 = new ComboBox();
            comboBox2.Location = new Point(comboBox1.Location.X, comboBox1.Location.Y + 35);
            panel.Controls.Add(comboBox2);

             richTextBox1 = new RichTextBox();
            richTextBox1.Size = new Size(300,200);
            richTextBox1.Location = new Point(comboBox1.Width + 40,comboBox1.Location.Y);
            panel.Controls.Add(richTextBox1);

            RadioButton radioButton1 = new RadioButton();
            radioButton1.Location = new Point(comboBox2.Location.X,comboBox2.Location.Y + 40);
            radioButton1.Text = ("ingen");
            panel.Controls.Add(radioButton1);
            radioButton1.CheckedChanged += fontChange;

            RadioButton radioButton2 = new RadioButton();
            radioButton2.Location = new Point(radioButton1.Location.X, radioButton1.Location.Y + 20);
            radioButton2.Text = ("fet");
            panel.Controls.Add(radioButton2);
            radioButton2.CheckedChanged += fontChange;

            RadioButton radioButton3 = new RadioButton();
            radioButton3.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y + 20);
            radioButton3.Text = ("kursiv");
            panel.Controls.Add(radioButton3);
            radioButton3.CheckedChanged += fontChange;

            RadioButton radioButton4 = new RadioButton();
            radioButton4.Location = new Point(radioButton3.Location.X, radioButton3.Location.Y + 20);
            radioButton4.Text = ("understruken");
            panel.Controls.Add(radioButton4);
            radioButton4.CheckedChanged += fontChange;

            panel.Location = new Point(ClientSize.Width / 2 - panel.Width / 2, ClientSize.Height / 2 - panel.Width / 2);
        }

        private void fontChange(object? sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial", 12);   
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            nameList1.Sort();
            richtextbox.Clear();
            foreach (string s in nameList1)
            {
                richtextbox.Text += s + Environment.NewLine;
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            nameList1.Add(textbox.Text);
            richtextbox.Text += textbox.Text + Environment.NewLine;
            textbox.Clear();
        }
    }
}