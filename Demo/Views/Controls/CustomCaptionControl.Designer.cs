﻿namespace Cube.Forms.Demo
{
    partial class CustomCaptionControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.LayoutPanel = new Cube.Forms.TableLayoutPanel();
            this.ExitButton = new Cube.Forms.FlatButton();
            this.MaximizeButton = new Cube.Forms.FlatButton();
            this.LogoPictureBox = new Cube.Forms.PictureBox();
            this.TitlePictureBox = new Cube.Forms.PictureBox();
            this.PaddingPanel = new Cube.Forms.Panel();
            this.MinimizeButton = new Cube.Forms.FlatButton();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 6;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanel.Controls.Add(this.ExitButton, 5, 0);
            this.LayoutPanel.Controls.Add(this.MaximizeButton, 4, 0);
            this.LayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.LayoutPanel.Controls.Add(this.TitlePictureBox, 1, 0);
            this.LayoutPanel.Controls.Add(this.PaddingPanel, 2, 0);
            this.LayoutPanel.Controls.Add(this.MinimizeButton, 3, 0);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Size = new System.Drawing.Size(400, 30);
            this.LayoutPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Content = "";
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = null;
            this.ExitButton.Location = new System.Drawing.Point(370, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.Styles.DisabledStyle.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Styles.DisabledStyle.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.ExitButton.Styles.DisabledStyle.ContentColor = System.Drawing.SystemColors.GrayText;
            this.ExitButton.Styles.MouseDownStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitButton.Styles.MouseDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.Styles.MouseDownStyle.BorderSize = 1;
            this.ExitButton.Styles.MouseOverStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ExitButton.Styles.MouseOverStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ExitButton.Styles.MouseOverStyle.BorderSize = 1;
            this.ExitButton.Styles.NormalStyle.BorderSize = 0;
            this.ExitButton.Styles.NormalStyle.Image = global::Cube.Forms.Demo.Properties.Resources.Close;
            this.ExitButton.TabIndex = 8;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Content = "";
            this.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Image = null;
            this.MaximizeButton.Location = new System.Drawing.Point(340, 0);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(30, 30);
            this.MaximizeButton.Styles.DisabledStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MaximizeButton.Styles.DisabledStyle.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.MaximizeButton.Styles.DisabledStyle.ContentColor = System.Drawing.SystemColors.GrayText;
            this.MaximizeButton.Styles.MouseDownStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaximizeButton.Styles.MouseDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaximizeButton.Styles.MouseDownStyle.BorderSize = 1;
            this.MaximizeButton.Styles.MouseOverStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MaximizeButton.Styles.MouseOverStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.MaximizeButton.Styles.MouseOverStyle.BorderSize = 1;
            this.MaximizeButton.Styles.NormalStyle.BorderSize = 0;
            this.MaximizeButton.Styles.NormalStyle.Image = global::Cube.Forms.Demo.Properties.Resources.Maximize;
            this.MaximizeButton.TabIndex = 7;
            this.MaximizeButton.UseVisualStyleBackColor = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = global::Cube.Forms.Demo.Properties.Resources.CubeSmall;
            this.LogoPictureBox.Location = new System.Drawing.Point(4, 0);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(20, 30);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlePictureBox.Image = global::Cube.Forms.Demo.Properties.Resources.Title;
            this.TitlePictureBox.Location = new System.Drawing.Point(24, 0);
            this.TitlePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(41, 30);
            this.TitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TitlePictureBox.TabIndex = 1;
            this.TitlePictureBox.TabStop = false;
            // 
            // PaddingPanel
            // 
            this.PaddingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaddingPanel.Location = new System.Drawing.Point(65, 0);
            this.PaddingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PaddingPanel.Name = "PaddingPanel";
            this.PaddingPanel.Size = new System.Drawing.Size(245, 30);
            this.PaddingPanel.TabIndex = 2;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Content = "";
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = null;
            this.MinimizeButton.Location = new System.Drawing.Point(310, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.Styles.DisabledStyle.BackColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.Styles.DisabledStyle.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.MinimizeButton.Styles.DisabledStyle.ContentColor = System.Drawing.SystemColors.GrayText;
            this.MinimizeButton.Styles.MouseDownStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MinimizeButton.Styles.MouseDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimizeButton.Styles.MouseDownStyle.BorderSize = 1;
            this.MinimizeButton.Styles.MouseOverStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MinimizeButton.Styles.MouseOverStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.MinimizeButton.Styles.MouseOverStyle.BorderSize = 1;
            this.MinimizeButton.Styles.NormalStyle.BorderSize = 0;
            this.MinimizeButton.Styles.NormalStyle.ContentColor = System.Drawing.SystemColors.ControlText;
            this.MinimizeButton.Styles.NormalStyle.Image = global::Cube.Forms.Demo.Properties.Resources.Minimize;
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // CustomCaptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutPanel);
            this.Name = "CustomCaptionControl";
            this.Size = new System.Drawing.Size(400, 30);
            this.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel LayoutPanel;
        private PictureBox LogoPictureBox;
        private PictureBox TitlePictureBox;
        private Panel PaddingPanel;
        private FlatButton MaximizeButton;
        private FlatButton ExitButton;
        private FlatButton MinimizeButton;
    }
}
