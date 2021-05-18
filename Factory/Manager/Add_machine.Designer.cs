
namespace Factory.Manager
{
    partial class Add_machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_machine));
            this.done = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameunderline = new System.Windows.Forms.Label();
            this.idunderline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.AutoEllipsis = true;
            this.done.BackColor = System.Drawing.Color.Black;
            this.done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.done.ForeColor = System.Drawing.Color.White;
            this.done.Location = new System.Drawing.Point(352, 242);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(188, 45);
            this.done.TabIndex = 27;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoEllipsis = true;
            this.loginButton.BackColor = System.Drawing.Color.DimGray;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(20, 242);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(188, 45);
            this.loginButton.TabIndex = 26;
            this.loginButton.Text = "Cancel";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.id.Location = new System.Drawing.Point(161, 130);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(188, 34);
            this.id.TabIndex = 19;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.name.Location = new System.Drawing.Point(161, 38);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 34);
            this.name.TabIndex = 15;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(43, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "*";
            // 
            // nameunderline
            // 
            this.nameunderline.AutoSize = true;
            this.nameunderline.ForeColor = System.Drawing.Color.Red;
            this.nameunderline.Location = new System.Drawing.Point(161, 75);
            this.nameunderline.Name = "nameunderline";
            this.nameunderline.Size = new System.Drawing.Size(147, 17);
            this.nameunderline.TabIndex = 29;
            this.nameunderline.Text = "--------------------------------------";
            this.nameunderline.UseCompatibleTextRendering = true;
            this.nameunderline.Visible = false;
            // 
            // idunderline
            // 
            this.idunderline.AutoSize = true;
            this.idunderline.ForeColor = System.Drawing.Color.Red;
            this.idunderline.Location = new System.Drawing.Point(161, 167);
            this.idunderline.Name = "idunderline";
            this.idunderline.Size = new System.Drawing.Size(147, 17);
            this.idunderline.TabIndex = 30;
            this.idunderline.Text = "--------------------------------------";
            this.idunderline.UseCompatibleTextRendering = true;
            this.idunderline.Visible = false;
            // 
            // Add_machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 353);
            this.Controls.Add(this.idunderline);
            this.Controls.Add(this.nameunderline);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.done);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_machine";
            this.Text = "Add machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nameunderline;
        private System.Windows.Forms.Label idunderline;
    }
}