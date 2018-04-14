namespace DB.APP.TableForm
{
    partial class ArchiveForm
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
            this.archiveDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // archiveDataGrid
            // 
            this.archiveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGrid.Location = new System.Drawing.Point(12, 12);
            this.archiveDataGrid.Name = "archiveDataGrid";
            this.archiveDataGrid.Size = new System.Drawing.Size(776, 374);
            this.archiveDataGrid.TabIndex = 0;
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.archiveDataGrid);
            this.Name = "ArchiveForm";
            this.Text = "ArchiveForm";
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView archiveDataGrid;
    }
}