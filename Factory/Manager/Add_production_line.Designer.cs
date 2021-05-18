
namespace Factory.Manager
{
    partial class Add_production_line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_production_line));
            this.done = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.locationunderline = new System.Windows.Forms.Label();
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
            this.done.Location = new System.Drawing.Point(361, 226);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(188, 45);
            this.done.TabIndex = 33;
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
            this.loginButton.Location = new System.Drawing.Point(29, 226);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(188, 45);
            this.loginButton.TabIndex = 32;
            this.loginButton.Text = "Cancel";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.id.Location = new System.Drawing.Point(170, 114);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(188, 34);
            this.id.TabIndex = 31;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID";
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.location.Location = new System.Drawing.Point(170, 22);
            this.location.Multiline = true;
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(188, 34);
            this.location.TabIndex = 29;
            this.location.TextChanged += new System.EventHandler(this.location_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(61, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "*";
            // 
            // locationunderline
            // 
            this.locationunderline.AutoSize = true;
            this.locationunderline.ForeColor = System.Drawing.Color.Red;
            this.locationunderline.Location = new System.Drawing.Point(170, 59);
            this.locationunderline.Name = "locationunderline";
            this.locationunderline.Size = new System.Drawing.Size(147, 17);
            this.locationunderline.TabIndex = 35;
            this.locationunderline.Text = "--------------------------------------";
            this.locationunderline.UseCompatibleTextRendering = true;
            this.locationunderline.Visible = false;
            // 
            // idunderline
            // 
            this.idunderline.AutoSize = true;
            this.idunderline.ForeColor = System.Drawing.Color.Red;
            this.idunderline.Location = new System.Drawing.Point(170, 151);
            this.idunderline.Name = "idunderline";
            this.idunderline.Size = new System.Drawing.Size(147, 17);
            this.idunderline.TabIndex = 36;
            this.idunderline.Text = "--------------------------------------";
            this.idunderline.UseCompatibleTextRendering = true;
            this.idunderline.Visible = false;
            // 
            // Add_production_line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idunderline);
            this.Controls.Add(this.locationunderline);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.done);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_production_line";
            this.Text = "Add_production_line";
            this.Load += new System.EventHandler(this.Add_production_line_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label locationunderline;
        private System.Windows.Forms.Label idunderline;
    }
}