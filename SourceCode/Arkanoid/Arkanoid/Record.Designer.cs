using System.ComponentModel;

namespace Arkanoid
{
  partial class Record
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.ptb_title = new System.Windows.Forms.PictureBox();
      this.dgv_records = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_title)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.dgv_records)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 5;
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel1.Controls.Add(this.ptb_title, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.dgv_records, 2, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 577);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // ptb_title
      // 
      this.ptb_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_title.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_title.Location = new System.Drawing.Point(206, 30);
      this.ptb_title.Name = "ptb_title";
      this.ptb_title.Size = new System.Drawing.Size(402, 131);
      this.ptb_title.TabIndex = 0;
      this.ptb_title.TabStop = false;
      // 
      // dgv_records
      // 
      this.dgv_records.AllowUserToAddRows = false;
      this.dgv_records.AllowUserToDeleteRows = false;
      this.dgv_records.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_records.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_records.Location = new System.Drawing.Point(206, 194);
      this.dgv_records.Name = "dgv_records";
      this.dgv_records.ReadOnly = true;
      this.dgv_records.Size = new System.Drawing.Size(402, 380);
      this.dgv_records.TabIndex = 1;
      // 
      // Record
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Record";
      this.Size = new System.Drawing.Size(817, 577);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.ptb_title)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.dgv_records)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgv_records;
    private System.Windows.Forms.PictureBox ptb_title;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
  }
}