namespace MoggInspector
{
    partial class MoggInspector
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
            this.WindowLabel = new System.Windows.Forms.Label();
            this.EncVerBox = new System.Windows.Forms.TextBox();
            this.EncVerLabel = new System.Windows.Forms.Label();
            this.AESKeyBox = new System.Windows.Forms.TextBox();
            this.AESKeyLbl = new System.Windows.Forms.Label();
            this.NonceBox = new System.Windows.Forms.TextBox();
            this.NonceLbl = new System.Windows.Forms.Label();
            this.EncSubVerLbl = new System.Windows.Forms.Label();
            this.EncSubVerBox = new System.Windows.Forms.TextBox();
            this.KeymasksLbl = new System.Windows.Forms.Label();
            this.XboxMaskBox = new System.Windows.Forms.TextBox();
            this.PS3MaskBox = new System.Windows.Forms.TextBox();
            this.XboxMaskLbl = new System.Windows.Forms.Label();
            this.PS3MaskLbl = new System.Windows.Forms.Label();
            this.EncTypeDescLbl = new System.Windows.Forms.TextBox();
            this.MaskErrorLbl = new System.Windows.Forms.Label();
            this.CorrectedPS3MaskBox = new System.Windows.Forms.TextBox();
            this.PatchMaskBtn = new System.Windows.Forms.Button();
            this.magicABox = new System.Windows.Forms.TextBox();
            this.magicALBL = new System.Windows.Forms.Label();
            this.magicBLbl = new System.Windows.Forms.Label();
            this.magicBBox = new System.Windows.Forms.TextBox();
            this.Ps3IndexLbl = new System.Windows.Forms.Label();
            this.Ps3IndexBox = new System.Windows.Forms.TextBox();
            this.XboxIndexLbl = new System.Windows.Forms.Label();
            this.XboxIndexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WindowLabel
            // 
            this.WindowLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowLabel.Location = new System.Drawing.Point(0, 10);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(599, 16);
            this.WindowLabel.TabIndex = 0;
            this.WindowLabel.Text = "Welcome to LocalH\'s MOGG Inspector! Drag and drop a MOGG here to analyze it.";
            this.WindowLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EncVerBox
            // 
            this.EncVerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncVerBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.EncVerBox.Location = new System.Drawing.Point(123, 39);
            this.EncVerBox.Name = "EncVerBox";
            this.EncVerBox.ReadOnly = true;
            this.EncVerBox.Size = new System.Drawing.Size(68, 23);
            this.EncVerBox.TabIndex = 1;
            this.EncVerBox.Text = "17 (0x11)";
            // 
            // EncVerLabel
            // 
            this.EncVerLabel.AutoSize = true;
            this.EncVerLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EncVerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncVerLabel.Location = new System.Drawing.Point(12, 41);
            this.EncVerLabel.Name = "EncVerLabel";
            this.EncVerLabel.Size = new System.Drawing.Size(105, 15);
            this.EncVerLabel.TabIndex = 2;
            this.EncVerLabel.Text = "Encryption version";
            // 
            // AESKeyBox
            // 
            this.AESKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AESKeyBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.AESKeyBox.Location = new System.Drawing.Point(357, 39);
            this.AESKeyBox.Name = "AESKeyBox";
            this.AESKeyBox.ReadOnly = true;
            this.AESKeyBox.Size = new System.Drawing.Size(230, 23);
            this.AESKeyBox.TabIndex = 3;
            this.AESKeyBox.Text = "0123456789ABCDEF0123456789ABCDEF";
            // 
            // AESKeyLbl
            // 
            this.AESKeyLbl.AutoSize = true;
            this.AESKeyLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AESKeyLbl.Location = new System.Drawing.Point(303, 41);
            this.AESKeyLbl.Name = "AESKeyLbl";
            this.AESKeyLbl.Size = new System.Drawing.Size(48, 15);
            this.AESKeyLbl.TabIndex = 4;
            this.AESKeyLbl.Text = "AES key";
            // 
            // NonceBox
            // 
            this.NonceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NonceBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.NonceBox.Location = new System.Drawing.Point(357, 67);
            this.NonceBox.Name = "NonceBox";
            this.NonceBox.ReadOnly = true;
            this.NonceBox.Size = new System.Drawing.Size(230, 23);
            this.NonceBox.TabIndex = 5;
            this.NonceBox.Text = "0123456789ABCDEF0123456789ABCDEF";
            // 
            // NonceLbl
            // 
            this.NonceLbl.AutoSize = true;
            this.NonceLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NonceLbl.Location = new System.Drawing.Point(303, 69);
            this.NonceLbl.Name = "NonceLbl";
            this.NonceLbl.Size = new System.Drawing.Size(42, 15);
            this.NonceLbl.TabIndex = 6;
            this.NonceLbl.Text = "Nonce";
            // 
            // EncSubVerLbl
            // 
            this.EncSubVerLbl.AutoSize = true;
            this.EncSubVerLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EncSubVerLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncSubVerLbl.Location = new System.Drawing.Point(12, 69);
            this.EncSubVerLbl.Name = "EncSubVerLbl";
            this.EncSubVerLbl.Size = new System.Drawing.Size(61, 15);
            this.EncSubVerLbl.TabIndex = 7;
            this.EncSubVerLbl.Text = "v17 keyset";
            // 
            // EncSubVerBox
            // 
            this.EncSubVerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncSubVerBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.EncSubVerBox.Location = new System.Drawing.Point(123, 67);
            this.EncSubVerBox.Name = "EncSubVerBox";
            this.EncSubVerBox.ReadOnly = true;
            this.EncSubVerBox.Size = new System.Drawing.Size(145, 23);
            this.EncSubVerBox.TabIndex = 8;
            this.EncSubVerBox.Text = "6 (Dance Central VR)";
            // 
            // KeymasksLbl
            // 
            this.KeymasksLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KeymasksLbl.Location = new System.Drawing.Point(357, 101);
            this.KeymasksLbl.Name = "KeymasksLbl";
            this.KeymasksLbl.Size = new System.Drawing.Size(230, 15);
            this.KeymasksLbl.TabIndex = 10;
            this.KeymasksLbl.Text = "Keymasks";
            this.KeymasksLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XboxMaskBox
            // 
            this.XboxMaskBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XboxMaskBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.XboxMaskBox.Location = new System.Drawing.Point(357, 148);
            this.XboxMaskBox.Name = "XboxMaskBox";
            this.XboxMaskBox.ReadOnly = true;
            this.XboxMaskBox.Size = new System.Drawing.Size(230, 23);
            this.XboxMaskBox.TabIndex = 9;
            this.XboxMaskBox.Text = "0123456789ABCDEF0123456789ABCDEF";
            // 
            // PS3MaskBox
            // 
            this.PS3MaskBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PS3MaskBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.PS3MaskBox.Location = new System.Drawing.Point(357, 119);
            this.PS3MaskBox.Name = "PS3MaskBox";
            this.PS3MaskBox.ReadOnly = true;
            this.PS3MaskBox.Size = new System.Drawing.Size(230, 23);
            this.PS3MaskBox.TabIndex = 11;
            this.PS3MaskBox.Text = "0123456789ABCDEF0123456789ABCDEF";
            // 
            // XboxMaskLbl
            // 
            this.XboxMaskLbl.AutoSize = true;
            this.XboxMaskLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XboxMaskLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XboxMaskLbl.Location = new System.Drawing.Point(326, 148);
            this.XboxMaskLbl.Name = "XboxMaskLbl";
            this.XboxMaskLbl.Size = new System.Drawing.Size(25, 15);
            this.XboxMaskLbl.TabIndex = 12;
            this.XboxMaskLbl.Text = "360";
            // 
            // PS3MaskLbl
            // 
            this.PS3MaskLbl.AutoSize = true;
            this.PS3MaskLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PS3MaskLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PS3MaskLbl.Location = new System.Drawing.Point(325, 121);
            this.PS3MaskLbl.Name = "PS3MaskLbl";
            this.PS3MaskLbl.Size = new System.Drawing.Size(26, 15);
            this.PS3MaskLbl.TabIndex = 13;
            this.PS3MaskLbl.Text = "PS3";
            // 
            // EncTypeDescLbl
            // 
            this.EncTypeDescLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncTypeDescLbl.Font = new System.Drawing.Font("Consolas", 10F);
            this.EncTypeDescLbl.Location = new System.Drawing.Point(200, 39);
            this.EncTypeDescLbl.Name = "EncTypeDescLbl";
            this.EncTypeDescLbl.ReadOnly = true;
            this.EncTypeDescLbl.Size = new System.Drawing.Size(68, 23);
            this.EncTypeDescLbl.TabIndex = 14;
            this.EncTypeDescLbl.Text = "HMX Forge";
            // 
            // MaskErrorLbl
            // 
            this.MaskErrorLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.MaskErrorLbl.Location = new System.Drawing.Point(12, 184);
            this.MaskErrorLbl.Name = "MaskErrorLbl";
            this.MaskErrorLbl.Size = new System.Drawing.Size(179, 30);
            this.MaskErrorLbl.TabIndex = 15;
            this.MaskErrorLbl.Text = "Incorrect PS3 keymask found!\r\nCorrect PS3 keymask calculated.";
            this.MaskErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CorrectedPS3MaskBox
            // 
            this.CorrectedPS3MaskBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorrectedPS3MaskBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.CorrectedPS3MaskBox.Location = new System.Drawing.Point(357, 190);
            this.CorrectedPS3MaskBox.Name = "CorrectedPS3MaskBox";
            this.CorrectedPS3MaskBox.ReadOnly = true;
            this.CorrectedPS3MaskBox.Size = new System.Drawing.Size(230, 23);
            this.CorrectedPS3MaskBox.TabIndex = 16;
            this.CorrectedPS3MaskBox.Text = "0123456789ABCDEF0123456789ABCDEF";
            // 
            // PatchMaskBtn
            // 
            this.PatchMaskBtn.AutoSize = true;
            this.PatchMaskBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatchMaskBtn.Location = new System.Drawing.Point(233, 189);
            this.PatchMaskBtn.Name = "PatchMaskBtn";
            this.PatchMaskBtn.Size = new System.Drawing.Size(118, 25);
            this.PatchMaskBtn.TabIndex = 17;
            this.PatchMaskBtn.Text = "Patch PS3 keymask";
            this.PatchMaskBtn.UseVisualStyleBackColor = true;
            // 
            // magicABox
            // 
            this.magicABox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.magicABox.Font = new System.Drawing.Font("Consolas", 10F);
            this.magicABox.Location = new System.Drawing.Point(66, 117);
            this.magicABox.Name = "magicABox";
            this.magicABox.ReadOnly = true;
            this.magicABox.Size = new System.Drawing.Size(115, 23);
            this.magicABox.TabIndex = 18;
            this.magicABox.Text = "0123456789ABCDEF";
            // 
            // magicALBL
            // 
            this.magicALBL.AutoSize = true;
            this.magicALBL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.magicALBL.Location = new System.Drawing.Point(12, 119);
            this.magicALBL.Name = "magicALBL";
            this.magicALBL.Size = new System.Drawing.Size(48, 15);
            this.magicALBL.TabIndex = 19;
            this.magicALBL.Text = "magicA";
            // 
            // magicBLbl
            // 
            this.magicBLbl.AutoSize = true;
            this.magicBLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.magicBLbl.Location = new System.Drawing.Point(12, 148);
            this.magicBLbl.Name = "magicBLbl";
            this.magicBLbl.Size = new System.Drawing.Size(47, 15);
            this.magicBLbl.TabIndex = 21;
            this.magicBLbl.Text = "magicB";
            // 
            // magicBBox
            // 
            this.magicBBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.magicBBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.magicBBox.Location = new System.Drawing.Point(66, 146);
            this.magicBBox.Name = "magicBBox";
            this.magicBBox.ReadOnly = true;
            this.magicBBox.Size = new System.Drawing.Size(115, 23);
            this.magicBBox.TabIndex = 20;
            this.magicBBox.Text = "0123456789ABCDEF";
            // 
            // Ps3IndexLbl
            // 
            this.Ps3IndexLbl.AutoSize = true;
            this.Ps3IndexLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ps3IndexLbl.Location = new System.Drawing.Point(200, 121);
            this.Ps3IndexLbl.Name = "Ps3IndexLbl";
            this.Ps3IndexLbl.Size = new System.Drawing.Size(78, 15);
            this.Ps3IndexLbl.TabIndex = 23;
            this.Ps3IndexLbl.Text = "PS3 key index";
            // 
            // Ps3IndexBox
            // 
            this.Ps3IndexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ps3IndexBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.Ps3IndexBox.Location = new System.Drawing.Point(284, 119);
            this.Ps3IndexBox.Name = "Ps3IndexBox";
            this.Ps3IndexBox.ReadOnly = true;
            this.Ps3IndexBox.Size = new System.Drawing.Size(18, 23);
            this.Ps3IndexBox.TabIndex = 22;
            this.Ps3IndexBox.Text = "5";
            this.Ps3IndexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // XboxIndexLbl
            // 
            this.XboxIndexLbl.AutoSize = true;
            this.XboxIndexLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XboxIndexLbl.Location = new System.Drawing.Point(200, 150);
            this.XboxIndexLbl.Name = "XboxIndexLbl";
            this.XboxIndexLbl.Size = new System.Drawing.Size(77, 15);
            this.XboxIndexLbl.TabIndex = 25;
            this.XboxIndexLbl.Text = "360 key index";
            // 
            // XboxIndexBox
            // 
            this.XboxIndexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XboxIndexBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.XboxIndexBox.Location = new System.Drawing.Point(284, 148);
            this.XboxIndexBox.Name = "XboxIndexBox";
            this.XboxIndexBox.ReadOnly = true;
            this.XboxIndexBox.Size = new System.Drawing.Size(18, 23);
            this.XboxIndexBox.TabIndex = 24;
            this.XboxIndexBox.Text = "11";
            // 
            // MoggInspector
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 225);
            this.Controls.Add(this.XboxIndexLbl);
            this.Controls.Add(this.XboxIndexBox);
            this.Controls.Add(this.Ps3IndexLbl);
            this.Controls.Add(this.Ps3IndexBox);
            this.Controls.Add(this.magicBLbl);
            this.Controls.Add(this.magicBBox);
            this.Controls.Add(this.magicALBL);
            this.Controls.Add(this.magicABox);
            this.Controls.Add(this.PatchMaskBtn);
            this.Controls.Add(this.CorrectedPS3MaskBox);
            this.Controls.Add(this.MaskErrorLbl);
            this.Controls.Add(this.EncTypeDescLbl);
            this.Controls.Add(this.PS3MaskLbl);
            this.Controls.Add(this.XboxMaskLbl);
            this.Controls.Add(this.PS3MaskBox);
            this.Controls.Add(this.KeymasksLbl);
            this.Controls.Add(this.XboxMaskBox);
            this.Controls.Add(this.EncSubVerBox);
            this.Controls.Add(this.EncSubVerLbl);
            this.Controls.Add(this.NonceLbl);
            this.Controls.Add(this.NonceBox);
            this.Controls.Add(this.AESKeyLbl);
            this.Controls.Add(this.AESKeyBox);
            this.Controls.Add(this.EncVerLabel);
            this.Controls.Add(this.EncVerBox);
            this.Controls.Add(this.WindowLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MoggInspector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOGG Inspector v1.0 by LocalH";
            this.Load += new System.EventHandler(this.MoggInspector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.TextBox EncVerBox;
        private System.Windows.Forms.Label EncVerLabel;
        private System.Windows.Forms.TextBox AESKeyBox;
        private System.Windows.Forms.Label AESKeyLbl;
        private System.Windows.Forms.TextBox NonceBox;
        private System.Windows.Forms.Label NonceLbl;
        private System.Windows.Forms.Label EncSubVerLbl;
        private System.Windows.Forms.TextBox EncSubVerBox;
        private System.Windows.Forms.Label KeymasksLbl;
        private System.Windows.Forms.TextBox XboxMaskBox;
        private System.Windows.Forms.TextBox PS3MaskBox;
        private System.Windows.Forms.Label XboxMaskLbl;
        private System.Windows.Forms.Label PS3MaskLbl;
        private System.Windows.Forms.TextBox EncTypeDescLbl;
        private System.Windows.Forms.Label MaskErrorLbl;
        private System.Windows.Forms.TextBox CorrectedPS3MaskBox;
        private System.Windows.Forms.Button PatchMaskBtn;
        private System.Windows.Forms.TextBox magicABox;
        private System.Windows.Forms.Label magicALBL;
        private System.Windows.Forms.Label magicBLbl;
        private System.Windows.Forms.TextBox magicBBox;
        private System.Windows.Forms.Label Ps3IndexLbl;
        private System.Windows.Forms.TextBox Ps3IndexBox;
        private System.Windows.Forms.Label XboxIndexLbl;
        private System.Windows.Forms.TextBox XboxIndexBox;
    }
}

