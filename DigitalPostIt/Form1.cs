using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DigitalPostIt
{
    public partial class Form1 : Form
    {

        public List<PostItData> postIts = new List<PostItData>();

        public static string saveAndLoadDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\Just Your Digital Post-It Note";

        public Form1()
        {
            InitializeComponent();
            StartUp();
        }

        private void StartUp()
        {
            CheckIfFirstTime();
        }

        public void CreatePostIts()
        {
            foreach (var data in postIts)
            {
                var newPage = new TabPage(data.title);
                newPage.BackColor = data.color;
                newPage.Controls.Add(CreateTitle(data));
                newPage.Controls.Add(CreateNoteContent(data));
                newPage.Controls.Add(CreateAddNoteButton(data));
                newPage.Controls.Add(CreateRemoveNoteButton(data));
                newPage.Controls.Add(CreateChangeColorButton(data));
                newPage.Controls.Add(CreateColorLabel(data));
                notes.TabPages.Add(newPage);
            }
        }

        private TextBox CreateTitle(PostItData data)
        {
            var newTitle = new TextBox();
            newTitle.Location = new Point(16, 17);
            newTitle.BackColor = data.color;
            newTitle.Text = data.title;
            newTitle.BorderStyle = BorderStyle.None;
            newTitle.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newTitle.Location = new Point(16, 17);
            newTitle.Size = new Size(394, 60);
            newTitle.TabIndex = 0;
            newTitle.Name = $"title_{data.index}";
            newTitle.TextChanged += noteContent_TextChanged;
            clickToType.SetToolTip(newTitle, "Click To Start Typing");
            return newTitle;
        }

        private TextBox CreateNoteContent(PostItData data)
        {
            var newBox = new TextBox();
            newBox.AcceptsReturn = true;
            newBox.AcceptsTab = true;
            newBox.BackColor = data.color;
            newBox.BorderStyle = BorderStyle.None;
            newBox.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newBox.Location = new Point(15, 102);
            newBox.Multiline = true;
            newBox.Size = new Size(809, 581);
            newBox.TabIndex = 1;
            newBox.TabStop = false;
            newBox.Name = $"noteContent_{data.index}";
            foreach (var item in data.note)
            {
                newBox.AppendText(item + Environment.NewLine);
            }
            clickToType.SetToolTip(newBox, "Click To Start Typing");
            newBox.TextChanged += noteContent_TextChanged;
            return newBox;
        }

        private Button CreateAddNoteButton(PostItData data)
        {
            var button = new Button();
            button.BackColor = Color.FromArgb(128, 255, 128);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.Location = new Point(706, 17);
            button.Size = new Size(53, 49);
            button.TabIndex = 4;
            button.Text = "+";
            clickToType.SetToolTip(button, "Click To Add A New Note");
            button.UseVisualStyleBackColor = false;
            button.Click += Create_Click;
            button.Name = $"addNote_{data.index}";
            return button;
        }

        private Button CreateRemoveNoteButton(PostItData data)
        {
            Button button = new Button();
            button.BackColor = Color.Red;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.ForeColor = SystemColors.Control;
            button.Location = new Point(775, 17);
            button.Size = new Size(53, 49);
            button.TabIndex = 5;
            button.Text = "-";
            clickToType.SetToolTip(button, "Click To Add A New Note");
            button.UseVisualStyleBackColor = false;
            button.Click += Remove_Click;
            button.Name = $"removeNote_{data.index}";
            return button;
        }

        private Button CreateChangeColorButton(PostItData data)
        {
            Button button = new Button();
            button.FlatAppearance.BorderSize = 3;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = SystemColors.ActiveCaptionText;
            button.Location = new Point(659, 25);
            button.Name = $"colorButton_{data.index}";
            button.Size = new Size(32, 32);
            button.TabIndex = 2;
            clickToType.SetToolTip(button, "Click To Change Color\r\n");
            button.UseVisualStyleBackColor = true;
            button.Click += Color_Click;
            return button;
        }

        private Label CreateColorLabel(PostItData data)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(603, 31);
            label.Name = "colorLabel";
            label.Size = new Size(48, 20);
            label.TabIndex = 3;
            colorLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Text = "color:";
            return label;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            File.WriteAllText($"{saveAndLoadDir}\\{postIts.Count}.postit", $"New Note\n255,255,128\nClick To Start Typing!\r\nJust Your Digital Postit Note, By Moonstone");
            notes.TabPages.Clear();
            //postIts.Add(new PostItData { title = "New Note", color = Color.FromArgb(255, 255, 128), note = new string[] { "Click To Start Typing!\r\n", "Just Your Digital Postit Note, By Moonstone" }, index = postIts.Count });
            postIts.Clear();
            LoadPostItData();
            CreatePostIts();
            notes.SelectedIndex = postIts.Count() - 1;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (postIts.Count == 1) return;
            File.Delete($"{saveAndLoadDir}\\{notes.SelectedIndex}.postit");
            //postIts.RemoveAt(notes.SelectedIndex);
            notes.TabPages.Clear();
            postIts.Clear();
            LoadPostItData();
            CreatePostIts();
            foreach (var item in Directory.GetFiles(saveAndLoadDir))
            {
                File.Delete(item);
            }
            int count = 0;
            foreach (var data in postIts)
            {
                string text = string.Join(Environment.NewLine, data.note);
                File.WriteAllText($"{saveAndLoadDir}\\{count}.postit", $"{data.title}\n{data.color.R},{data.color.G},{data.color.B}\n{text}");
                count++;
            }
            notes.SelectedIndex = postIts.Count() - 1;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            //colorDialog1.AllowFullOpen = false;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var data = postIts[notes.SelectedIndex];
                data.color = colorDialog1.Color;
                TextBox box = (TextBox)Controls.Find($"noteContent_{data.index}", true)[0];
                TextBox title = (TextBox)Controls.Find($"title_{data.index}", true)[0];
                box.BackColor = data.color;
                title.BackColor = data.color;
                notes.SelectedTab.BackColor = data.color;
                Debug.WriteLine("Change Detected");
                File.Delete($"{saveAndLoadDir}\\{notes.SelectedIndex}.postit");
                data.note = box.Lines;
                data.title = title.Text;
                notes.SelectedTab.Text = data.title;
                data.color = notes.SelectedTab.BackColor;
                string text = string.Join(Environment.NewLine, data.note);
                Debug.WriteLine($"{data.title}\n{data.color.R},{data.color.G},{data.color.B}\n{text}");
                File.WriteAllText($"{saveAndLoadDir}\\{notes.SelectedIndex}.postit", $"{data.title}\n{data.color.R},{data.color.G},{data.color.B}\n{text}");
                Debug.WriteLine("Saved");
                postIts.RemoveAt(notes.SelectedIndex);
                postIts.Insert(notes.SelectedIndex, data);
            }
        }


        public void CheckIfFirstTime()
        {
            if (!Directory.Exists(saveAndLoadDir))
            {
                Directory.CreateDirectory(saveAndLoadDir);
                File.WriteAllText($"{saveAndLoadDir}\\0.postit", $"New Note\n255,255,128\nClick To Start Typing!\r\nJust Your Digital Postit Note, By Moonstone");
            }
            notes.TabPages.Remove(tabPage1);
            LoadPostItData();
            CreatePostIts();
        }

        public void LoadPostItData()
        {
            foreach (string path in Directory.GetFiles(saveAndLoadDir))
            {
                ParseData(path);
            }

        }

        public void ParseData(string path)
        {
            string[] text = File.ReadAllLines(path);
            PostItData data = new PostItData();
            data.title = text[0];
            data.color = Color.FromArgb(Convert.ToInt32(text[1].Split(',').First()), Convert.ToInt32(text[1].Split(',')[1]), Convert.ToInt32(text[1].Split(',').Last()));
            List<string> notedata = new List<string>();
            int count = 0;
            foreach (var line in text)
            {
                if(count > 1)
                {
                    notedata.Add(line);
                }
                count++;
            }
            data.note = notedata.ToArray();
            data.index = Convert.ToInt32(path.Split('\\').Last().Split('.').First());
            postIts.Add(data);
        }

        public void SaveData(string title, string note, Color color, int index)
        {

            File.WriteAllText($"{saveAndLoadDir}\\{index}.postit", $"{title}\n{color.R},{color.G},{color.B}\n{note}");

        }

        private void noteContent_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists($"{saveAndLoadDir}\\{notes.SelectedIndex}.postit"))
            {
                Debug.WriteLine("Change Detected");
                File.Delete($"{saveAndLoadDir}\\{notes.SelectedIndex}.postit");
                var data = postIts[notes.SelectedIndex];
                TextBox box = (TextBox)Controls.Find($"noteContent_{data.index}", true)[0];
                TextBox title = (TextBox)Controls.Find($"title_{data.index}", true)[0];
                data.note = box.Lines;
                data.title = title.Text;
                notes.SelectedTab.Text = data.title;
                data.color = notes.SelectedTab.BackColor;
                string text = string.Join(Environment.NewLine, data.note);
                Debug.WriteLine($"{data.title}\n{data.color.R},{data.color.G},{data.color.B}\n{text}");
                File.WriteAllText($"{saveAndLoadDir}\\{notes.SelectedIndex}.postit", $"{data.title}\n{data.color.R},{data.color.G},{data.color.B}\n{text}");
                Debug.WriteLine("Saved");
                postIts.RemoveAt(notes.SelectedIndex);
                postIts.Insert(notes.SelectedIndex, data);
            }
        }

    }

    public struct PostItData
    {
        public string title;
        public string[] note;
        public Color color;
        public int index;
    }
}
