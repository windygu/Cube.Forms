﻿namespace Cube.Forms.Demo
{
    partial class FormBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new Cube.Forms.Button();
            this.TitlePictureBox = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.HeaderSplitter = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderSplitter)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.TitlePictureBox);
            this.HeaderPanel.Controls.Add(this.LogoPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(300, 25);
            this.HeaderPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CloseButton.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderSize = 0;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::Cube.Forms.Demo.Properties.Resources.ButtonClose;
            this.CloseButton.Location = new System.Drawing.Point(275, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.Surface.CheckedBackColor = System.Drawing.Color.Empty;
            this.CloseButton.Surface.CheckedBackgroundImage = null;
            this.CloseButton.Surface.CheckedBorderColor = System.Drawing.Color.Empty;
            this.CloseButton.Surface.CheckedForeColor = System.Drawing.Color.Empty;
            this.CloseButton.Surface.CheckedImage = null;
            this.CloseButton.Surface.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CloseButton.Surface.MouseDownBackgroundImage = null;
            this.CloseButton.Surface.MouseDownBorderColor = System.Drawing.Color.Empty;
            this.CloseButton.Surface.MouseDownForeColor = System.Drawing.Color.Empty;
            this.CloseButton.Surface.MouseDownImage = null;
            this.CloseButton.Surface.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CloseButton.Surface.MouseOverBackgroundImage = null;
            this.CloseButton.Surface.MouseOverBorderColor = System.Drawing.Color.Empty;
            this.CloseButton.Surface.MouseOverForeColor = System.Drawing.Color.Empty;
            this.CloseButton.Surface.MouseOverImage = null;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TitlePictureBox.Image = global::Cube.Forms.Demo.Properties.Resources.LogoTitle;
            this.TitlePictureBox.Location = new System.Drawing.Point(32, 6);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(41, 13);
            this.TitlePictureBox.TabIndex = 1;
            this.TitlePictureBox.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.Image = global::Cube.Forms.Demo.Properties.Resources.LogoSmall;
            this.LogoPictureBox.Location = new System.Drawing.Point(6, 2);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(20, 20);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // HeaderSplitter
            // 
            this.HeaderSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.HeaderSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderSplitter.Location = new System.Drawing.Point(0, 25);
            this.HeaderSplitter.Name = "HeaderSplitter";
            this.HeaderSplitter.Size = new System.Drawing.Size(300, 1);
            this.HeaderSplitter.TabIndex = 8;
            this.HeaderSplitter.TabStop = false;
            // 
            // FormBase
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.HeaderSplitter);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.Text = "Cube.Forms.Demo";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderSplitter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private Button CloseButton;
        private System.Windows.Forms.PictureBox TitlePictureBox;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox HeaderSplitter;
    }
}