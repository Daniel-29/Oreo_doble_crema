using System.ComponentModel;

namespace Arkanoid
{
  partial class Home
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbly_core = new System.Windows.Forms.TableLayoutPanel();
      this.tbly_menu = new System.Windows.Forms.TableLayoutPanel();
      this.ptb_titulo = new System.Windows.Forms.PictureBox();
      this.ptb_play = new System.Windows.Forms.PictureBox();
      this.ptb_record = new System.Windows.Forms.PictureBox();
      this.ptb_exit = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.ptb_back = new System.Windows.Forms.PictureBox();
      this.ptb_max = new System.Windows.Forms.PictureBox();
      this.ptb_min = new System.Windows.Forms.PictureBox();
      this.ptb_close = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tbly_core.SuspendLayout();
      this.tbly_menu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_titulo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_play)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_record)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_exit)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_back)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_max)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_min)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_close)).BeginInit();
      this.SuspendLayout();
      // 
      // tbly_core
      // 
      this.tbly_core.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tbly_core.BackColor = System.Drawing.Color.Transparent;
      this.tbly_core.ColumnCount = 1;
      this.tbly_core.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tbly_core.Controls.Add(this.tbly_menu, 0, 1);
      this.tbly_core.Controls.Add(this.tableLayoutPanel1, 0, 0);
      this.tbly_core.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbly_core.Location = new System.Drawing.Point(0, 0);
      this.tbly_core.Name = "tbly_core";
      this.tbly_core.RowCount = 2;
      this.tbly_core.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
      this.tbly_core.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
      this.tbly_core.Size = new System.Drawing.Size(1200, 720);
      this.tbly_core.TabIndex = 0;
      // 
      // tbly_menu
      // 
      this.tbly_menu.BackColor = System.Drawing.Color.Transparent;
      this.tbly_menu.ColumnCount = 3;
      this.tbly_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tbly_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tbly_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tbly_menu.Controls.Add(this.ptb_titulo, 1, 1);
      this.tbly_menu.Controls.Add(this.ptb_play, 1, 3);
      this.tbly_menu.Controls.Add(this.ptb_record, 1, 5);
      this.tbly_menu.Controls.Add(this.ptb_exit, 1, 7);
      this.tbly_menu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbly_menu.Location = new System.Drawing.Point(3, 53);
      this.tbly_menu.Name = "tbly_menu";
      this.tbly_menu.RowCount = 9;
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.tbly_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tbly_menu.Size = new System.Drawing.Size(1194, 664);
      this.tbly_menu.TabIndex = 0;
      // 
      // ptb_titulo
      // 
      this.ptb_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_titulo.Location = new System.Drawing.Point(301, 36);
      this.ptb_titulo.Name = "ptb_titulo";
      this.ptb_titulo.Size = new System.Drawing.Size(591, 160);
      this.ptb_titulo.TabIndex = 0;
      this.ptb_titulo.TabStop = false;
      // 
      // ptb_play
      // 
      this.ptb_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_play.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_play.Location = new System.Drawing.Point(301, 235);
      this.ptb_play.Name = "ptb_play";
      this.ptb_play.Size = new System.Drawing.Size(591, 93);
      this.ptb_play.TabIndex = 1;
      this.ptb_play.TabStop = false;
      this.ptb_play.Click += new System.EventHandler(this.ptb_play_Click);
      this.ptb_play.MouseEnter += new System.EventHandler(this.ptb_play_MouseEnter);
      this.ptb_play.MouseLeave += new System.EventHandler(this.ptb_play_MouseLeave);
      // 
      // ptb_record
      // 
      this.ptb_record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_record.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_record.Location = new System.Drawing.Point(301, 367);
      this.ptb_record.Name = "ptb_record";
      this.ptb_record.Size = new System.Drawing.Size(591, 93);
      this.ptb_record.TabIndex = 2;
      this.ptb_record.TabStop = false;
      this.ptb_record.Click += new System.EventHandler(this.ptb_record_Click);
      this.ptb_record.MouseEnter += new System.EventHandler(this.ptb_record_MouseEnter);
      this.ptb_record.MouseLeave += new System.EventHandler(this.ptb_record_MouseLeave);
      // 
      // ptb_exit
      // 
      this.ptb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_exit.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_exit.Location = new System.Drawing.Point(301, 499);
      this.ptb_exit.Name = "ptb_exit";
      this.ptb_exit.Size = new System.Drawing.Size(591, 93);
      this.ptb_exit.TabIndex = 3;
      this.ptb_exit.TabStop = false;
      this.ptb_exit.Click += new System.EventHandler(this.ptb_exit_Click);
      this.ptb_exit.MouseEnter += new System.EventHandler(this.ptb_exit_MouseEnter);
      this.ptb_exit.MouseLeave += new System.EventHandler(this.ptb_exit_MouseLeave);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 5;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
      this.tableLayoutPanel1.Controls.Add(this.ptb_back, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.ptb_max, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.ptb_min, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.ptb_close, 4, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 44);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // ptb_back
      // 
      this.ptb_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_back.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_back.Location = new System.Drawing.Point(3, 3);
      this.ptb_back.Name = "ptb_back";
      this.ptb_back.Size = new System.Drawing.Size(41, 38);
      this.ptb_back.TabIndex = 0;
      this.ptb_back.TabStop = false;
      this.ptb_back.Click += new System.EventHandler(this.ptb_back_Click);
      // 
      // ptb_max
      // 
      this.ptb_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_max.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_max.Location = new System.Drawing.Point(1099, 3);
      this.ptb_max.Name = "ptb_max";
      this.ptb_max.Size = new System.Drawing.Size(41, 38);
      this.ptb_max.TabIndex = 1;
      this.ptb_max.TabStop = false;
      this.ptb_max.Click += new System.EventHandler(this.ptb_max_Click);
      // 
      // ptb_min
      // 
      this.ptb_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_min.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_min.Location = new System.Drawing.Point(1052, 3);
      this.ptb_min.Name = "ptb_min";
      this.ptb_min.Size = new System.Drawing.Size(41, 38);
      this.ptb_min.TabIndex = 2;
      this.ptb_min.TabStop = false;
      this.ptb_min.Click += new System.EventHandler(this.ptb_min_Click);
      // 
      // ptb_close
      // 
      this.ptb_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ptb_close.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptb_close.Location = new System.Drawing.Point(1146, 3);
      this.ptb_close.Name = "ptb_close";
      this.ptb_close.Size = new System.Drawing.Size(45, 38);
      this.ptb_close.TabIndex = 3;
      this.ptb_close.TabStop = false;
      this.ptb_close.Click += new System.EventHandler(this.ptb_close_Click);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(50, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(996, 44);
      this.label1.TabIndex = 4;
      this.label1.Text = "ARKANOID";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1200, 720);
      this.Controls.Add(this.tbly_core);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Home";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ARKANOID";
      this.tbly_core.ResumeLayout(false);
      this.tbly_menu.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.ptb_titulo)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_play)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_record)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_exit)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.ptb_back)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_max)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_min)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ptb_close)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox ptb_back;
    private System.Windows.Forms.PictureBox ptb_close;
    private System.Windows.Forms.PictureBox ptb_exit;
    private System.Windows.Forms.PictureBox ptb_max;
    private System.Windows.Forms.PictureBox ptb_min;
    private System.Windows.Forms.PictureBox ptb_play;
    private System.Windows.Forms.PictureBox ptb_record;
    private System.Windows.Forms.PictureBox ptb_titulo;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tbly_core;
    private System.Windows.Forms.TableLayoutPanel tbly_menu;

    #endregion
  }
}