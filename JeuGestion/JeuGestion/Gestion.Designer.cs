namespace JeuGestion
{
    partial class Gestion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_CreateP = new System.Windows.Forms.Button();
            this.comboBox_Classe = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Classe = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Level = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_NewP = new System.Windows.Forms.Button();
            this.listViewP = new System.Windows.Forms.ListView();
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.niveau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_CreateP);
            this.tabPage1.Controls.Add(this.comboBox_Classe);
            this.tabPage1.Controls.Add(this.textBox_Name);
            this.tabPage1.Controls.Add(this.label_Classe);
            this.tabPage1.Controls.Add(this.label_Name);
            this.tabPage1.Controls.Add(this.button_Level);
            this.tabPage1.Controls.Add(this.button_Remove);
            this.tabPage1.Controls.Add(this.button_NewP);
            this.tabPage1.Controls.Add(this.listViewP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vos personnages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_CreateP
            // 
            this.button_CreateP.Location = new System.Drawing.Point(506, 95);
            this.button_CreateP.Name = "button_CreateP";
            this.button_CreateP.Size = new System.Drawing.Size(98, 23);
            this.button_CreateP.TabIndex = 9;
            this.button_CreateP.Text = "button_CreateP";
            this.button_CreateP.UseVisualStyleBackColor = true;
            this.button_CreateP.Visible = false;
            this.button_CreateP.Click += new System.EventHandler(this.button_CreateP_Click);
            // 
            // comboBox_Classe
            // 
            this.comboBox_Classe.FormattingEnabled = true;
            this.comboBox_Classe.Items.AddRange(new object[] {
            "Guerrier",
            "Archer"});
            this.comboBox_Classe.Location = new System.Drawing.Point(506, 55);
            this.comboBox_Classe.Name = "comboBox_Classe";
            this.comboBox_Classe.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Classe.TabIndex = 8;
            this.comboBox_Classe.Visible = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(503, 28);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(124, 20);
            this.textBox_Name.TabIndex = 7;
            this.textBox_Name.Visible = false;
            // 
            // label_Classe
            // 
            this.label_Classe.AutoSize = true;
            this.label_Classe.Location = new System.Drawing.Point(433, 58);
            this.label_Classe.Name = "label_Classe";
            this.label_Classe.Size = new System.Drawing.Size(66, 13);
            this.label_Classe.TabIndex = 6;
            this.label_Classe.Text = "label_Classe";
            this.label_Classe.Visible = false;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(433, 28);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(63, 13);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "label_Name";
            this.label_Name.Visible = false;
            // 
            // button_Level
            // 
            this.button_Level.Location = new System.Drawing.Point(322, 276);
            this.button_Level.Name = "button_Level";
            this.button_Level.Size = new System.Drawing.Size(95, 23);
            this.button_Level.TabIndex = 4;
            this.button_Level.Text = "button_Level";
            this.button_Level.UseVisualStyleBackColor = true;
            this.button_Level.Click += new System.EventHandler(this.button_Level_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(183, 276);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(95, 23);
            this.button_Remove.TabIndex = 3;
            this.button_Remove.Text = "button_Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_NewP
            // 
            this.button_NewP.Location = new System.Drawing.Point(46, 276);
            this.button_NewP.Name = "button_NewP";
            this.button_NewP.Size = new System.Drawing.Size(95, 23);
            this.button_NewP.TabIndex = 2;
            this.button_NewP.Text = "button_NewP";
            this.button_NewP.UseVisualStyleBackColor = true;
            this.button_NewP.Click += new System.EventHandler(this.button_NewP_Click);
            // 
            // listViewP
            // 
            this.listViewP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom,
            this.classe,
            this.niveau,
            this.hp,
            this.atk,
            this.dex});
            this.listViewP.FullRowSelect = true;
            this.listViewP.Location = new System.Drawing.Point(7, 6);
            this.listViewP.MultiSelect = false;
            this.listViewP.Name = "listViewP";
            this.listViewP.Size = new System.Drawing.Size(419, 239);
            this.listViewP.TabIndex = 0;
            this.listViewP.UseCompatibleStateImageBehavior = false;
            this.listViewP.View = System.Windows.Forms.View.Details;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 80;
            // 
            // classe
            // 
            this.classe.Text = "Classe";
            this.classe.Width = 80;
            // 
            // niveau
            // 
            this.niveau.Text = "Niveau";
            // 
            // hp
            // 
            this.hp.Text = "Point de vie";
            this.hp.Width = 79;
            // 
            // atk
            // 
            this.atk.Text = "Attaque";
            // 
            // dex
            // 
            this.dex.Text = "Dextérité";
            this.dex.Width = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vos mondes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 363);
            this.Controls.Add(this.tabControl1);
            this.Name = "Gestion";
            this.Text = "-";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gestion_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewP;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader classe;
        private System.Windows.Forms.ColumnHeader niveau;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_NewP;
        private System.Windows.Forms.Button button_Level;
        private System.Windows.Forms.ColumnHeader hp;
        private System.Windows.Forms.ColumnHeader atk;
        private System.Windows.Forms.ColumnHeader dex;
        private System.Windows.Forms.Button button_CreateP;
        private System.Windows.Forms.ComboBox comboBox_Classe;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Classe;
        private System.Windows.Forms.Label label_Name;
    }
}