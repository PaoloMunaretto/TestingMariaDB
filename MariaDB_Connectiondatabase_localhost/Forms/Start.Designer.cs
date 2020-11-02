namespace MariaDB
{
    partial class Start
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.panelIntestazione = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btInsert = new System.Windows.Forms.Button();
            this.btNewID = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridElement = new System.Windows.Forms.DataGridView();
            this.panelIntestazione.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElement)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIntestazione
            // 
            this.panelIntestazione.Controls.Add(this.panelButtons);
            this.panelIntestazione.Controls.Add(this.cbTable);
            this.panelIntestazione.Controls.Add(this.button1);
            this.panelIntestazione.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIntestazione.Location = new System.Drawing.Point(0, 0);
            this.panelIntestazione.Name = "panelIntestazione";
            this.panelIntestazione.Size = new System.Drawing.Size(800, 155);
            this.panelIntestazione.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btInsert);
            this.panelButtons.Controls.Add(this.btNewID);
            this.panelButtons.Controls.Add(this.btModify);
            this.panelButtons.Controls.Add(this.btDelete);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(241, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(559, 155);
            this.panelButtons.TabIndex = 6;
            // 
            // btInsert
            // 
            this.btInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsert.Location = new System.Drawing.Point(110, 13);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(85, 38);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "INSERT";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // btNewID
            // 
            this.btNewID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewID.Location = new System.Drawing.Point(19, 13);
            this.btNewID.Name = "btNewID";
            this.btNewID.Size = new System.Drawing.Size(85, 38);
            this.btNewID.TabIndex = 5;
            this.btNewID.Text = "NEW ID";
            this.btNewID.UseVisualStyleBackColor = true;
            this.btNewID.Click += new System.EventHandler(this.BtNewID_Click);
            // 
            // btModify
            // 
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModify.Location = new System.Drawing.Point(19, 86);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(85, 38);
            this.btModify.TabIndex = 3;
            this.btModify.Text = "MODIFY";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.BtModify_Click);
            // 
            // btDelete
            // 
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Location = new System.Drawing.Point(110, 86);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(85, 38);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTable.ForeColor = System.Drawing.Color.White;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(12, 96);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(222, 28);
            this.cbTable.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Connection_Click);
            // 
            // dataGridElement
            // 
            this.dataGridElement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridElement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridElement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridElement.Location = new System.Drawing.Point(0, 155);
            this.dataGridElement.Name = "dataGridElement";
            this.dataGridElement.RowHeadersWidth = 51;
            this.dataGridElement.RowTemplate.Height = 24;
            this.dataGridElement.Size = new System.Drawing.Size(800, 295);
            this.dataGridElement.TabIndex = 1;
            this.dataGridElement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridElement_CellClick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridElement);
            this.Controls.Add(this.panelIntestazione);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "MariaDB localhost Database";
            this.panelIntestazione.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIntestazione;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridElement;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btNewID;
        private System.Windows.Forms.Panel panelButtons;
    }
}

