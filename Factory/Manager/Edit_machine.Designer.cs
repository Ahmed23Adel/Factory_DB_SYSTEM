
namespace Factory.Manager
{
    partial class Edit_machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_machine));
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idunderline = new System.Windows.Forms.Label();
            this.nameunderline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.id.Location = new System.Drawing.Point(432, 58);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(188, 34);
            this.id.TabIndex = 50;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(364, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "ID";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.name.Location = new System.Drawing.Point(151, 58);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 34);
            this.name.TabIndex = 48;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(-88, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Name";
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(33, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 45);
            this.button3.TabIndex = 46;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // done
            // 
            this.done.AutoEllipsis = true;
            this.done.BackColor = System.Drawing.Color.Black;
            this.done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.done.ForeColor = System.Drawing.Color.White;
            this.done.Location = new System.Drawing.Point(453, 157);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(188, 45);
            this.done.TabIndex = 45;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // button5
            // 
            this.button5.AutoEllipsis = true;
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(244, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 45);
            this.button5.TabIndex = 44;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(401, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "*";
            // 
            // idunderline
            // 
            this.idunderline.AutoSize = true;
            this.idunderline.ForeColor = System.Drawing.Color.Red;
            this.idunderline.Location = new System.Drawing.Point(432, 95);
            this.idunderline.Name = "idunderline";
            this.idunderline.Size = new System.Drawing.Size(147, 17);
            this.idunderline.TabIndex = 53;
            this.idunderline.Text = "--------------------------------------";
            this.idunderline.UseCompatibleTextRendering = true;
            this.idunderline.Visible = false;
            // 
            // nameunderline
            // 
            this.nameunderline.AutoSize = true;
            this.nameunderline.ForeColor = System.Drawing.Color.Red;
            this.nameunderline.Location = new System.Drawing.Point(151, 95);
            this.nameunderline.Name = "nameunderline";
            this.nameunderline.Size = new System.Drawing.Size(147, 17);
            this.nameunderline.TabIndex = 54;
            this.nameunderline.Text = "--------------------------------------";
            this.nameunderline.UseCompatibleTextRendering = true;
            this.nameunderline.Visible = false;
            // 
            // Edit_machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 331);
            this.Controls.Add(this.nameunderline);
            this.Controls.Add(this.idunderline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.done);
            this.Controls.Add(this.button5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_machine";
            this.Text = "Edit_machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idunderline;
        private System.Windows.Forms.Label nameunderline;
    }
}