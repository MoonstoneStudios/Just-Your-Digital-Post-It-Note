namespace DigitalPostIt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.removeNote = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.noteContent = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.clickToType = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.notes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notes
            // 
            this.notes.Controls.Add(this.tabPage1);
            this.notes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes.Location = new System.Drawing.Point(-2, -1);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.SelectedIndex = 0;
            this.notes.Size = new System.Drawing.Size(842, 723);
            this.notes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.removeNote);
            this.tabPage1.Controls.Add(this.addNote);
            this.tabPage1.Controls.Add(this.colorLabel);
            this.tabPage1.Controls.Add(this.colorButton);
            this.tabPage1.Controls.Add(this.noteContent);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Font = new System.Drawing.Font("Sniglet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 690);
            this.tabPage1.TabIndex = 15;
            this.tabPage1.Text = "New Note";
            // 
            // removeNote
            // 
            this.removeNote.BackColor = System.Drawing.Color.Red;
            this.removeNote.FlatAppearance.BorderSize = 0;
            this.removeNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeNote.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeNote.ForeColor = System.Drawing.SystemColors.Control;
            this.removeNote.Location = new System.Drawing.Point(775, 17);
            this.removeNote.Name = "removeNote";
            this.removeNote.Size = new System.Drawing.Size(53, 49);
            this.removeNote.TabIndex = 5;
            this.removeNote.Text = "-";
            this.clickToType.SetToolTip(this.removeNote, "Click To Add A New Note");
            this.removeNote.UseVisualStyleBackColor = false;
            // 
            // addNote
            // 
            this.addNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addNote.FlatAppearance.BorderSize = 0;
            this.addNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNote.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNote.Location = new System.Drawing.Point(706, 17);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(53, 49);
            this.addNote.TabIndex = 4;
            this.addNote.Text = "+";
            this.clickToType.SetToolTip(this.addNote, "Click To Add A New Note");
            this.addNote.UseVisualStyleBackColor = false;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(601, 29);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(52, 23);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "color:";
            // 
            // colorButton
            // 
            this.colorButton.FlatAppearance.BorderSize = 3;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorButton.Location = new System.Drawing.Point(659, 25);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(32, 32);
            this.colorButton.TabIndex = 2;
            this.clickToType.SetToolTip(this.colorButton, "Click To Change Color\r\n");
            this.colorButton.UseVisualStyleBackColor = true;
            // 
            // noteContent
            // 
            this.noteContent.AcceptsReturn = true;
            this.noteContent.AcceptsTab = true;
            this.noteContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.noteContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteContent.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteContent.Location = new System.Drawing.Point(15, 102);
            this.noteContent.Multiline = true;
            this.noteContent.Name = "noteContent";
            this.noteContent.Size = new System.Drawing.Size(809, 581);
            this.noteContent.TabIndex = 1;
            this.noteContent.TabStop = false;
            this.noteContent.Text = "Lorem Ipsum";
            this.clickToType.SetToolTip(this.noteContent, "Click To Start Typing");
            this.noteContent.TextChanged += new System.EventHandler(this.noteContent_TextChanged);
            this.noteContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noteContent_TextChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(16, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(394, 67);
            this.title.TabIndex = 0;
            this.title.Text = "New Note";
            this.clickToType.SetToolTip(this.title, "Click To Start Typing");
            this.title.TextChanged += new System.EventHandler(this.noteContent_TextChanged);
            // 
            // clickToType
            // 
            this.clickToType.AutoPopDelay = 5000;
            this.clickToType.InitialDelay = 1000;
            this.clickToType.ReshowDelay = 300;
            this.clickToType.ToolTipTitle = "Tip!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 721);
            this.Controls.Add(this.notes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Your Digital Post-It Note";
            this.notes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox noteContent;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.ToolTip clickToType;
        private System.Windows.Forms.Button removeNote;
        private System.Windows.Forms.TabControl notes;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

