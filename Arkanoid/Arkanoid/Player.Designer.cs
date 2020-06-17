using System.ComponentModel;

namespace Arkanoid
{
  partial class Player
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
      this.txt_nickname = new System.Windows.Forms.TextBox();
      this.ptb_continuar = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.n_vidas = new System.Windows.Forms.NumericUpDown();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_title)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_continuar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.n_vidas)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(
        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.ptb_title, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.txt_nickname, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.ptb_continuar, 1, 7);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.n_vidas, 1, 5);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 9;
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.681818F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.40909F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.681818F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.04546F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.954546F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.681818F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.34091F));
      this.tableLayoutPanel1.RowStyles.Add(
        new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.113636F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 577);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // ptb_title
      // 
      this.ptb_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_title.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_title.Location = new System.Drawing.Point(207, 35);
      this.ptb_title.Name = "ptb_title";
      this.ptb_title.Size = new System.Drawing.Size(402, 157);
      this.ptb_title.TabIndex = 0;
      this.ptb_title.TabStop = false;
      // 
      // txt_nickname
      // 
      this.txt_nickname.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_nickname.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.txt_nickname.Location = new System.Drawing.Point(207, 230);
      this.txt_nickname.Name = "txt_nickname";
      this.txt_nickname.Size = new System.Drawing.Size(402, 58);
      this.txt_nickname.TabIndex = 1;
      this.txt_nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // ptb_continuar
      // 
      this.ptb_continuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_continuar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_continuar.Location = new System.Drawing.Point(207, 457);
      this.ptb_continuar.Name = "ptb_continuar";
      this.ptb_continuar.Size = new System.Drawing.Size(402, 82);
      this.ptb_continuar.TabIndex = 2;
      this.ptb_continuar.TabStop = false;
      this.ptb_continuar.Click += new System.EventHandler(this.ptb_continuar_Click);
      this.ptb_continuar.MouseEnter += new System.EventHandler(this.ptb_continuar_MouseEnter);
      this.ptb_continuar.MouseLeave += new System.EventHandler(this.ptb_continuar_MouseLeave);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(207, 325);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(402, 45);
      this.label1.TabIndex = 3;
      this.label1.Text = "Vidas:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // n_vidas
      // 
      this.n_vidas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.n_vidas.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.n_vidas.Location = new System.Drawing.Point(207, 373);
      this.n_vidas.Maximum = new decimal(new int[] {10, 0, 0, 0});
      this.n_vidas.Minimum = new decimal(new int[] {1, 0, 0, 0});
      this.n_vidas.Name = "n_vidas";
      this.n_vidas.Size = new System.Drawing.Size(402, 36);
      this.n_vidas.TabIndex = 4;
      this.n_vidas.Value = new decimal(new int[] {1, 0, 0, 0});
      // 
      // Player
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Player";
      this.Size = new System.Drawing.Size(817, 577);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_title)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_continuar)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.n_vidas)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown n_vidas;
    private System.Windows.Forms.PictureBox ptb_continuar;
    private System.Windows.Forms.PictureBox ptb_title;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox txt_nickname;

    #endregion
  }
}