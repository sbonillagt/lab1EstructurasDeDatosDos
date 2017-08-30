namespace Lab1_ED2_2001516
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbDuration = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cBoxPlayList = new System.Windows.Forms.ComboBox();
            this.btnAddToPl = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Todas Las Canciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Crear PlayList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Mostrar PlayList";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(612, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Ordenar Ascendentemente";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(612, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ordenar Descendentemente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbName.Location = new System.Drawing.Point(613, 269);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(62, 17);
            this.rbName.TabIndex = 7;
            this.rbName.TabStop = true;
            this.rbName.Text = "Nombre";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbDuration
            // 
            this.rbDuration.AutoSize = true;
            this.rbDuration.Location = new System.Drawing.Point(613, 293);
            this.rbDuration.Name = "rbDuration";
            this.rbDuration.Size = new System.Drawing.Size(68, 17);
            this.rbDuration.TabIndex = 8;
            this.rbDuration.TabStop = true;
            this.rbDuration.Text = "Duracion";
            this.rbDuration.UseVisualStyleBackColor = true;
            this.rbDuration.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cArtist,
            this.cAlbum,
            this.cDuration});
            this.dataGridView1.Location = new System.Drawing.Point(31, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 313);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // cName
            // 
            this.cName.FillWeight = 200F;
            this.cName.Frozen = true;
            this.cName.HeaderText = "Nombre";
            this.cName.Name = "cName";
            // 
            // cArtist
            // 
            this.cArtist.Frozen = true;
            this.cArtist.HeaderText = "Artista";
            this.cArtist.Name = "cArtist";
            // 
            // cAlbum
            // 
            this.cAlbum.Frozen = true;
            this.cAlbum.HeaderText = "Album";
            this.cAlbum.Name = "cAlbum";
            // 
            // cDuration
            // 
            this.cDuration.Frozen = true;
            this.cDuration.HeaderText = "Duracion";
            this.cDuration.Name = "cDuration";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // cBoxPlayList
            // 
            this.cBoxPlayList.FormattingEnabled = true;
            this.cBoxPlayList.Location = new System.Drawing.Point(613, 75);
            this.cBoxPlayList.Name = "cBoxPlayList";
            this.cBoxPlayList.Size = new System.Drawing.Size(164, 21);
            this.cBoxPlayList.TabIndex = 13;
            // 
            // btnAddToPl
            // 
            this.btnAddToPl.Location = new System.Drawing.Point(613, 223);
            this.btnAddToPl.Name = "btnAddToPl";
            this.btnAddToPl.Size = new System.Drawing.Size(162, 23);
            this.btnAddToPl.TabIndex = 14;
            this.btnAddToPl.Text = "Agregar canciones a playlist";
            this.btnAddToPl.UseVisualStyleBackColor = true;
            this.btnAddToPl.Click += new System.EventHandler(this.btnAddToPl_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(31, 398);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(576, 98);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 106);
            this.label1.TabIndex = 16;
            this.label1.Text = "YuTUNES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnAddToPl);
            this.Controls.Add(this.cBoxPlayList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbDuration);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbDuration;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ComboBox cBoxPlayList;
        private System.Windows.Forms.Button btnAddToPl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDuration;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
    }
}