namespace MariaDB
{
    partial class ModifyDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyDatabase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripIntestazione = new System.Windows.Forms.ToolStrip();
            this.SavetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.InformationtoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.toolStripIntestazione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripIntestazione
            // 
            this.toolStripIntestazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toolStripIntestazione.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripIntestazione.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavetoolStripButton,
            this.toolStripSeparator1,
            this.InformationtoolStripLabel});
            this.toolStripIntestazione.Location = new System.Drawing.Point(0, 0);
            this.toolStripIntestazione.Name = "toolStripIntestazione";
            this.toolStripIntestazione.Size = new System.Drawing.Size(800, 27);
            this.toolStripIntestazione.TabIndex = 0;
            this.toolStripIntestazione.Text = "toolStrip1";
            // 
            // SavetoolStripButton
            // 
            this.SavetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SavetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SavetoolStripButton.Image")));
            this.SavetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavetoolStripButton.Name = "SavetoolStripButton";
            this.SavetoolStripButton.Size = new System.Drawing.Size(29, 24);
            this.SavetoolStripButton.Text = "Save";
            this.SavetoolStripButton.Click += new System.EventHandler(this.SavetoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // InformationtoolStripLabel
            // 
            this.InformationtoolStripLabel.Name = "InformationtoolStripLabel";
            this.InformationtoolStripLabel.Size = new System.Drawing.Size(21, 24);
            this.InformationtoolStripLabel.Text = "__";
            // 
            // dataGridTable
            // 
            this.dataGridTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTable.Location = new System.Drawing.Point(0, 27);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.RowHeadersWidth = 51;
            this.dataGridTable.RowTemplate.Height = 24;
            this.dataGridTable.Size = new System.Drawing.Size(800, 423);
            this.dataGridTable.TabIndex = 1;
            // 
            // ModifyDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.toolStripIntestazione);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyDatabase";
            this.Text = "Modify Database";
            this.toolStripIntestazione.ResumeLayout(false);
            this.toolStripIntestazione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripIntestazione;
        private System.Windows.Forms.ToolStripButton SavetoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel InformationtoolStripLabel;
        private System.Windows.Forms.DataGridView dataGridTable;
    }
}