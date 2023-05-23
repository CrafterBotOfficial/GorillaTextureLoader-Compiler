namespace App
{
    partial class MakerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakerWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.useleaf = new System.Windows.Forms.CheckBox();
            this.isverfiedbtn = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.TextBox();
            this.compilebtn = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.credittitle = new System.Windows.Forms.Label();
            this.makerzonetitle = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.Label();
            this.primaryatlas = new System.Windows.Forms.Label();
            this.secondaryatlas = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.leaf = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.forestatlaspriview = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forestatlaspriview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.useleaf);
            this.panel1.Controls.Add(this.isverfiedbtn);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.compilebtn);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.credittitle);
            this.panel1.Location = new System.Drawing.Point(568, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(51000);
            this.panel1.Size = new System.Drawing.Size(220, 426);
            this.panel1.TabIndex = 0;
            // 
            // useleaf
            // 
            this.useleaf.AutoSize = true;
            this.useleaf.Location = new System.Drawing.Point(137, 368);
            this.useleaf.Name = "useleaf";
            this.useleaf.Size = new System.Drawing.Size(80, 17);
            this.useleaf.TabIndex = 10;
            this.useleaf.Text = "Export Leaf";
            this.useleaf.UseVisualStyleBackColor = true;
            // 
            // isverfiedbtn
            // 
            this.isverfiedbtn.AutoSize = true;
            this.isverfiedbtn.Location = new System.Drawing.Point(19, 368);
            this.isverfiedbtn.Name = "isverfiedbtn";
            this.isverfiedbtn.Size = new System.Drawing.Size(72, 17);
            this.isverfiedbtn.TabIndex = 9;
            this.isverfiedbtn.Text = "Is Verified";
            this.isverfiedbtn.UseVisualStyleBackColor = true;
            this.isverfiedbtn.Visible = false;
            this.isverfiedbtn.CheckedChanged += new System.EventHandler(this.isverfiedbtn_CheckedChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(10, 263);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 20);
            this.title.TabIndex = 8;
            this.title.Text = "My Title";
            // 
            // compilebtn
            // 
            this.compilebtn.Location = new System.Drawing.Point(58, 391);
            this.compilebtn.Name = "compilebtn";
            this.compilebtn.Size = new System.Drawing.Size(118, 26);
            this.compilebtn.TabIndex = 1;
            this.compilebtn.Text = "Compile";
            this.compilebtn.UseVisualStyleBackColor = true;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(10, 289);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(199, 72);
            this.description.TabIndex = 7;
            this.description.Text = "My description";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 131);
            this.label1.TabIndex = 6;
            this.label1.Text = "This project was inspired by fchb1239s GorillaTexturepacks preview video. By pres" +
    "sing the \"Compile\" button below, you agree that this texture will not offer a in" +
    " game advantage.";
            // 
            // credittitle
            // 
            this.credittitle.AutoSize = true;
            this.credittitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.credittitle.Location = new System.Drawing.Point(55, 12);
            this.credittitle.Name = "credittitle";
            this.credittitle.Size = new System.Drawing.Size(121, 26);
            this.credittitle.TabIndex = 5;
            this.credittitle.Text = "Credits, Information \r\nand Legal";
            // 
            // makerzonetitle
            // 
            this.makerzonetitle.AutoSize = true;
            this.makerzonetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makerzonetitle.Location = new System.Drawing.Point(12, 9);
            this.makerzonetitle.Name = "makerzonetitle";
            this.makerzonetitle.Size = new System.Drawing.Size(168, 31);
            this.makerzonetitle.TabIndex = 1;
            this.makerzonetitle.Text = "Maker Zone";
            // 
            // ground
            // 
            this.ground.AutoSize = true;
            this.ground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ground.Location = new System.Drawing.Point(85, 62);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(64, 20);
            this.ground.TabIndex = 3;
            this.ground.Text = "Ground";
            // 
            // primaryatlas
            // 
            this.primaryatlas.AutoSize = true;
            this.primaryatlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.primaryatlas.Location = new System.Drawing.Point(70, 192);
            this.primaryatlas.Name = "primaryatlas";
            this.primaryatlas.Size = new System.Drawing.Size(110, 20);
            this.primaryatlas.TabIndex = 5;
            this.primaryatlas.Text = "Primary Atlas";
            // 
            // secondaryatlas
            // 
            this.secondaryatlas.AutoSize = true;
            this.secondaryatlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.secondaryatlas.Location = new System.Drawing.Point(218, 63);
            this.secondaryatlas.Name = "secondaryatlas";
            this.secondaryatlas.Size = new System.Drawing.Size(96, 20);
            this.secondaryatlas.TabIndex = 7;
            this.secondaryatlas.Text = "Tree Stump";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(18, 415);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(218, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tree Room";
            // 
            // leaf
            // 
            this.leaf.AutoSize = true;
            this.leaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.leaf.Location = new System.Drawing.Point(397, 62);
            this.leaf.Name = "leaf";
            this.leaf.Size = new System.Drawing.Size(42, 20);
            this.leaf.TabIndex = 12;
            this.leaf.Text = "Leaf";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Application.Properties.Resources.cherryblossomsmall;
            this.pictureBox4.InitialImage = global::Application.Properties.Resources.forestatlas;
            this.pictureBox4.Location = new System.Drawing.Point(355, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Application.Properties.Resources.treeroomatlas;
            this.pictureBox3.InitialImage = global::Application.Properties.Resources.forestatlas;
            this.pictureBox3.Location = new System.Drawing.Point(207, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Application.Properties.Resources.Tree_Texture_Baker_mat__MainTex_atlas_0;
            this.pictureBox2.InitialImage = global::Application.Properties.Resources.forestatlas;
            this.pictureBox2.Location = new System.Drawing.Point(207, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // forestatlaspriview
            // 
            this.forestatlaspriview.Image = global::Application.Properties.Resources.forestatlas;
            this.forestatlaspriview.InitialImage = global::Application.Properties.Resources.forestatlas;
            this.forestatlaspriview.Location = new System.Drawing.Point(57, 215);
            this.forestatlaspriview.Name = "forestatlaspriview";
            this.forestatlaspriview.Size = new System.Drawing.Size(123, 97);
            this.forestatlaspriview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forestatlaspriview.TabIndex = 4;
            this.forestatlaspriview.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MakerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaf);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.secondaryatlas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.primaryatlas);
            this.Controls.Add(this.forestatlaspriview);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.makerzonetitle);
            this.Controls.Add(this.panel1);
            this.Name = "MakerWindow";
            this.Text = "Texture Compiler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forestatlaspriview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label credittitle;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button compilebtn;
        private System.Windows.Forms.Label makerzonetitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ground;
        private System.Windows.Forms.Label primaryatlas;
        private System.Windows.Forms.PictureBox forestatlaspriview;
        private System.Windows.Forms.Label secondaryatlas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox isverfiedbtn;
        private System.Windows.Forms.Label leaf;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox useleaf;
    }
}