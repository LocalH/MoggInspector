using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using MoggInspectorLib;

namespace MoggInspector
{
    public partial class MoggInspector : Form
    {
        uint Ps3MaskOffset;
        byte[] Ps3FixedMask;

        public MoggInspector()
        {
            InitializeComponent();
            this.DragEnter += new DragEventHandler(this.MoggInspector_DragEnter);
            this.DragDrop += new DragEventHandler(this.MoggInspector_DragDrop);
            PatchMaskBtn.Click += new EventHandler(this.PatchMaskBtn_Click);
        }

        private void MoggInspector_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MoggInspector_DragDrop(object sender, DragEventArgs e)
        {
            uint OggOffset = 0;
            byte[] MoggHeader;
            var dropped = (string[])e.Data.GetData(DataFormats.FileDrop);
            var files = dropped.ToList();

            if (files.Count() == 0)
                throw new Exception(string.Format("no files dropped!"));
            if (files.Count() > 1)
                throw new Exception(string.Format("more than one file dropped, one only!"));

            //MessageBox.Show(files[0]);

            string fileName = files[0];

            using (var stream = File.Open(fileName, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream))
                {
                    stream.Seek(4, SeekOrigin.Begin);
                    OggOffset = reader.ReadUInt32();
                    stream.Seek(0, SeekOrigin.Begin);
                    MoggHeader = reader.ReadBytes((int)(OggOffset));
                    stream.Close();
                }
            }

            WindowLabel.Text = files[0];
            XboxIndexBox.Text = "";
            Ps3IndexBox.Text = "";
            magicBBox.Text = "";
            magicABox.Text = "";
            CorrectedPS3MaskBox.Text = "";
            EncTypeDescBox.Text = "";
            PS3MaskBox.Text = "";
            XboxMaskBox.Text = "";
            EncSubVerBox.Text = "";
            NonceBox.Text = "";
            PS3AESKeyBox.Text = "";
            XboxAESKeyBox.Text = "";
            EncVerBox.Text = "";
            MaskErrorLbl.Visible = false;
            MaskErrorLbl.Text = "Incorrect PS3 keymask found!\r\nCorrect PS3 keymask calculated.";
            PatchMaskBtn.Visible = false;
            CorrectedPS3MaskBox.Visible = false;

            var kc = new KeyChain();
            kc.DeriveKeys(MoggHeader, false);
            if (kc.Version > 11 && (!kc.IsC3Mogg && kc.KeymaskMismatch))
            {
            }
            if (kc.KeymaskMismatch)
            {
                MaskErrorLbl.Visible = true;
                PatchMaskBtn.Visible = true;
                CorrectedPS3MaskBox.Visible = true;
                CorrectedPS3MaskBox.Text = BitConverter.ToString(kc.Ps3FixedMask).Replace("-", string.Empty);
                Ps3MaskOffset = kc.Ps3MaskOffset;
                Ps3FixedMask = kc.Ps3FixedMask;
                kc.DeriveKeys(MoggHeader, true);
                if (kc.XboxAesKey.SequenceEqual(kc.Ps3AesKey))
                {
                    MaskErrorLbl.Visible = true;
                    MaskErrorLbl.Text = "RED KEY MOGG FOUND!\r\nSEND TO LOCAL H PLS";
                    PatchMaskBtn.Visible = false;
                    kc.KeymaskMismatch = false;
                }
                else
                {
                    kc.DeriveKeys(MoggHeader, false); //re-run green key derivation to reload those values for unknown non-red mismatches
                }
            }

            switch (kc.Version)
            {
                case 10:
                    EncVerBox.Text = "10 (0x0A)";
                    EncTypeDescBox.Text = "GH2/Unenc";
                    break;
                case 11:
                    if (kc.IsC3Mogg)
                    {
                        EncVerBox.Text = "11 (0x0B)";
                        EncTypeDescBox.Text = "C3 OG";
                    }
                    else
                    {
                        EncVerBox.Text = "11 (0x0B)";
                        EncTypeDescBox.Text = "HMX RB1";
                    }
                    break;
                case 12:
                    if (kc.IsC3Mogg)
                    {
                        EncVerBox.Text = "12 (0x0C)";
                        EncTypeDescBox.Text = "C3 Old";
                    }
                    else
                    {
                        EncVerBox.Text = "12 (0x0C)";
                        EncTypeDescBox.Text = "HMX RB2";
                    }
                    break;
                case 13:
                    EncVerBox.Text = "13 (0x0D)";
                    EncTypeDescBox.Text = "C3 New";
                    break;
                case 14:
                    EncVerBox.Text = "14 (0x0E)";
                    EncTypeDescBox.Text = "HMX RB2";
                    break;
                case 15:
                    EncVerBox.Text = "15 (0x0F)";
                    EncTypeDescBox.Text = "HMX RBN";
                    break;
                case 16:
                    EncVerBox.Text = "16 (0x10)";
                    EncTypeDescBox.Text = "HMX RB3";
                    break;
                case 17:
                    EncVerBox.Text = "17 (0x11)";
                    EncTypeDescBox.Text = "HMX Forge";
                    break;
                default:
                    EncVerBox.Text = String.Format("{0} (0x{0:X2})", kc.Version);
                    EncTypeDescBox.Text = "Unknown";
                    break;
            }

            if (kc.Version > 10)
            {
                NonceBox.Text = BitConverter.ToString(kc.Nonce).Replace("-", string.Empty);
                PS3AESKeyBox.Text = BitConverter.ToString(kc.Ps3AesKey).Replace("-", string.Empty);
                XboxAESKeyBox.Text = BitConverter.ToString(kc.XboxAesKey).Replace("-", string.Empty);
            }

            if (kc.Version > 11)
            {
                magicABox.Text = BitConverter.ToString(kc.MagicA).Replace("-", string.Empty);
                magicBBox.Text = BitConverter.ToString(kc.MagicB).Replace("-", string.Empty);
                XboxMaskBox.Text = BitConverter.ToString(kc.XboxMaskDec).Replace("-", string.Empty);
                PS3MaskBox.Text = BitConverter.ToString(kc.Ps3Mask).Replace("-", string.Empty);
                XboxIndexBox.Text = kc.XboxIndex.ToString();
                Ps3IndexBox.Text = kc.Ps3Index.ToString();
            }
            if (kc.Version == 17)
            {
                switch (kc.V17Keyset)
                {
                    case 1:
                        EncSubVerBox.Text = "1 (Rock Band 4)";
                        break;
                    case 4:
                        EncSubVerBox.Text = "4 (DropMix)";
                        break;
                    case 6:
                        EncSubVerBox.Text = "6 (Dance Central VR)";
                        break;
                    case 8:
                        EncSubVerBox.Text = "8 (Audica)";
                        break;
                    case 10:
                        EncSubVerBox.Text = "10 (FUSER)";
                        break;
                    default:
                        EncSubVerBox.Text = String.Format("{0} (unknown)",kc.V17Keyset);
                        break;
                }
            }

        }
        private void MoggInspector_Load(object sender, EventArgs e)
        {
            XboxIndexBox.Text = "";
            Ps3IndexBox.Text = "";
            magicBBox.Text = "";
            magicABox.Text = "";
            CorrectedPS3MaskBox.Text = "";
            EncTypeDescBox.Text = "";
            PS3MaskBox.Text = "";
            XboxMaskBox.Text = "";
            EncSubVerBox.Text = "";
            NonceBox.Text = "";
            PS3AESKeyBox.Text = "";
            XboxAESKeyBox.Text = "";
            EncVerBox.Text = "";
            MaskErrorLbl.Visible = false;
            PatchMaskBtn.Visible = false;
            CorrectedPS3MaskBox.Visible = false;
        }
        private void PatchMaskBtn_Click(object sender, EventArgs e)
        {
            string fileName = WindowLabel.Text; //gross hack I know but the label will always be set when this button is visible so it's ok

            using (var stream = File.Open(fileName, FileMode.Open))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    stream.Seek(Ps3MaskOffset, SeekOrigin.Begin);
                    writer.Write(Ps3FixedMask);
                    stream.Flush();
                    stream.Close();
                }
            }

            MaskErrorLbl.Text = "Incorrect PS3 keymask found!\r\nCorrect keymask now PATCHED.";
            MaskErrorLbl.ForeColor = Color.Black;
            PS3MaskBox.Text = BitConverter.ToString(Ps3FixedMask).Replace("-", string.Empty);
            PatchMaskBtn.Visible = false;
        }

    }
}
